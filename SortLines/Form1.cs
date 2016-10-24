using System;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SortLines {
    public partial class Form1 : Form {

        #region Vars

        int[] arry    = new int[50];
        int sortType  = 0;
        int sleepTime = 100;
        int writes    = 0;
        bool goFast   = false;

        Random ran = new Random();

        private delegate void dUpdatePanel();

        #endregion

        #region Constructor & Events

        public Form1() {
            InitializeComponent();
            reset();

            cboSort.SelectedIndex  = 0;
            cboStyle.SelectedIndex = 0;
        }

        private void tbSpeed_Scroll(object sender, EventArgs e) {
            gbxSpeed.Text = "Speed (" + tbSpeed.Value.ToString() + " hz)";
        }

        private void pnlMain_Paint(object sender, PaintEventArgs e) {
            Graphics g   = e.Graphics;
            float offset = 0.0f;
            float width  = (float)pnlMain.Width / (float)arry.Length;

            for (int x = 0; x < arry.Length; x++) {
                int height = Convert.ToInt32(Convert.ToDouble(pnlMain.Height) * (Convert.ToDouble(arry[x]) / arry.Length));

                if (cboStyle.SelectedIndex == 0) { // Lines
                    g.FillRectangle(Brushes.ForestGreen,
                        new RectangleF(offset, pnlMain.Height - height, width, height));

                } else if (cboStyle.SelectedIndex == 1) { // Boxes
                    g.FillRectangle(Brushes.ForestGreen,
                        new RectangleF(offset, pnlMain.Height - height, width, width));

                } else if (cboStyle.SelectedIndex == 2) { // ?????
                    g.FillRectangle(Brushes.ForestGreen,
                        new RectangleF(offset, pnlMain.Height - height, width, ran.Next(1, height)));

                }

                offset += width;
            }
        }

        private void btnSort_Click(object sender, EventArgs e) {

            if (!bgwMain.IsBusy) {
                sortType = cboSort.SelectedIndex;

                if (sortType == 0) {
                    btnStop.Show();
                }

                btnReset.Hide();
                btnSort.Hide();
                cboSort.Enabled  = false;
                txtItems.Enabled = false;
                writes = 0;
                lblWrites.Text = "";
                bgwMain.RunWorkerAsync();
            }
        }

        private void txtItems_ValueChanged(object sender, EventArgs e) {
            arry = new int[(int)txtItems.Value];
            reset();
        }

        private void reset() {
            for (int x = 0; x < arry.Length; x++) {
                // arry[x] = ran.Next(1, 101);
                arry[x] = x + 1;
            }

            arry = arry.OrderBy(x => ran.Next()).ToArray();
            pnlMain.Refresh();
        }

        private void btnReset_Click(object sender, EventArgs e) {
            reset();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e) {
            this.Refresh();
        }

        private void btnStop_Click(object sender, EventArgs e) {
            bgwMain.CancelAsync();
            btnStop.Hide();
        }

        #endregion

        #region Sorting

        private void swap(ref int a, ref int b) {
            int temp = a;
            a = b;
            b = temp;
        }

        private void insertionSort(int[] a) {

            for (int x = 1; x < a.Length; x++) {
                int iPoint = x;
                while (iPoint > 0 && a[iPoint - 1] > a[iPoint]) {
                    swap(ref a[iPoint], ref a[iPoint - 1]);
                    iPoint--;

                    updateGraph();
                }
            }
        }

        private void bubbleSort(int[] a) {
            bool switched = true;

            while (switched) {
                switched = false;
                for (int x = 1; x < a.Length; x++) {
                    if (a[x - 1] > a[x]) {
                        swap(ref a[x], ref a[x - 1]);
                        switched = true;

                        updateGraph();
                    }
                }
            }
        }

        private void coctailShakerSort(int[] a) {
            bool swapped;
            do {
                swapped = false;

                for (int x = 0; x < a.Length - 2; x++) {
                    if (a[x] > a[x + 1]) {
                        swap(ref a[x], ref a[x + 1]);
                        swapped = true;

                        updateGraph();
                    }
                }

                if (!swapped) {
                    break;
                }

                for (int x = a.Length - 2; x >= 0; x--) {
                    if (a[x] > a[x + 1]) {
                        swap(ref a[x], ref a[x + 1]);
                        swapped = true;

                        updateGraph();
                    }
                }

            } while (swapped);
        }

        private void oddEvenSort(int[] a) {
            bool sorted = false;

            while (!sorted) {
                sorted = true;

                for (int x = 0; x < a.Length - 1; x += 2) {
                    if (a[x] > a[x + 1]) {
                        swap(ref a[x], ref a[x + 1]);
                        sorted = false;

                        updateGraph();
                    }
                }

                for (int x = 1; x < a.Length - 1; x += 2) {
                    if (a[x] > a[x + 1]) {
                        swap(ref a[x], ref a[x + 1]);
                        sorted = false;

                        updateGraph();
                    }
                }
            }
        }

        private void cycleSort(int[] a) {
            for (int x = 0; x < a.Length - 1; x++) {
                int item = a[x];

                int pos = x;
                for (int y = x + 1; y < a.Length; y++) {
                    if (a[y] < item) {
                        pos++;
                    }
                }

                if (pos != x) { // found an item
                    while (item == a[pos]) { // put at end of duplicates
                        pos++;
                    }

                    swap(ref a[pos], ref item); // swapperunio
                    updateGraph();

                    while (pos != x) { // cycle
                        pos = x;
                        for (int y = x + 1; y < a.Length; y++) {
                            if (a[y] < item) {
                                pos++;
                            }
                        }

                        while (item == a[pos]) { // put at end of duplicates
                            pos++;
                        }

                        swap(ref a[pos], ref item); // swapperunio
                        updateGraph();
                    }
                }
            }
        }

        private void selectSort(int[] a) {
            
            for (int x = 0; x < a.Length; x++) {
                int minIndex = x;

                for (int y = x + 1; y < a.Length; y++) {
                    if (a[minIndex] > a[y]) {
                        minIndex = y;
                    }
                }

                if (minIndex != x) {
                    swap(ref a[minIndex], ref a[x]);
                    updateGraph();
                }
            }
        }

        private void stoogeSort(int[] a, int low, int high) {
            if (a[low] > a[high]) {
                swap(ref a[low], ref a[high]);
                updateGraph();
            }

            if ((high - low + 1) > 2) {
                int offset = (high - low + 1) / 3;
                stoogeSort(a, low, high - offset);
                stoogeSort(a, low + offset, high);
                stoogeSort(a, low, high - offset);
            }
        }

        private void quickSort(int[] a, int low, int high) {
            if (low < high) {
                int index = partition(a, low, high);
                quickSort(a, low,  index - 1);
                quickSort(a, index + 1, high);
            }
        }

        private int partition(int[] a, int low, int high) {
            int pivotPoint = a[high];
            int index = low;

            for (int x = low; x < high; x++) {
                if (a[x] <= pivotPoint) {
                    swap(ref a[x], ref a[index]);
                    updateGraph();

                    index++;
                }
            }

            swap(ref a[index], ref a[high]);
            updateGraph();

            return index;
        }

        private void bogoSort(int[] a) {
            int[] sorted = a.ToArray();
            Array.Sort(sorted);

            bool allSame = false;
            while (!allSame) {
                if (bgwMain.CancellationPending) {
                    return;
                }

                int[] temp = a.OrderBy(x => ran.Next()).ToArray();
                for (int x = 0; x < a.Length; x++) {
                    swap(ref a[x], ref temp[x]);
                }

                updateGraph();

                allSame = true;
                for (int x = 0; x < a.Length; x++) {
                    if (a[x] != sorted[x]) {
                        allSame = false;
                        break;
                    }
                }
            }
        }

        private void combSort(int[] a) {
            int gap = a.Length;
            double shrink = 1.3;
            bool sorted = false;

            while (!sorted) {
                gap = (int)Math.Floor((double)gap / shrink);

                if (gap > 1) {
                    sorted = false;
                } else {
                    gap = 1;
                    sorted = true;
                }

                int index = 0;
                while ((index + gap) < a.Length) {
                    if (a[index] > a[index + gap]) {
                        swap(ref a[index], ref a[index + gap]);
                        updateGraph();

                        sorted = false;
                    }

                    index++;
                }
            }
        }

        #endregion

        #region BGW & Related

        private void updateGraph() {
            pnlMain.Invoke(new dUpdatePanel(updatePanel));

            if (!chkFast.Checked) {
                System.Threading.Thread.Sleep(sleepTime);
            }

            writes++;
        }

        private void updatePanel() {
            pnlMain.Invalidate();
            sleepTime = 1000 / tbSpeed.Value;
        }

        private void bgwMain_DoWork(object sender, DoWorkEventArgs e) {
            switch (sortType) {
                case 0:
                    bogoSort(arry);
                    break;
                case 1:
                    bubbleSort(arry);
                    break;
                case 2:
                    coctailShakerSort(arry);
                    break;
                case 3:
                    combSort(arry);
                    break;
                case 4:
                    cycleSort(arry);
                    break;
                case 5:
                    insertionSort(arry);
                    break;
                case 6:
                    oddEvenSort(arry);
                    break;
                case 7:
                    selectSort(arry);
                    break;
                case 8:
                    stoogeSort(arry, 0, arry.Length - 1);
                    break;
                case 9:
                    quickSort(arry, 0, arry.Length - 1);
                    break;
            }
        }

        private void bgwMain_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e) {
            btnReset.Show();
            btnSort.Show();
            cboSort.Enabled  = true;
            txtItems.Enabled = true;
            lblWrites.Text = writes.ToString();
        }

        #endregion
    }
}
