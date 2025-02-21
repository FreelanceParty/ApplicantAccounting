using System.Drawing.Printing;

namespace ApplicantAccounting.ValueObjects;

public class DataGridViewPrinter
    {
        private DataGridView _dgv;
        private PrintDocument _printDoc;
        private int _currentRow;
        private int _totalWidth;
        private float _columnWidthScale;
        private StringFormat _strFormat;
        private Pen _gridPen;

        public DataGridViewPrinter(DataGridView dataGridView)
        {
            _dgv = dataGridView;
            _printDoc = new PrintDocument();
            _printDoc.PrintPage += new PrintPageEventHandler(PrintPage);
            _strFormat = new StringFormat
            {
                Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center,
                Trimming = StringTrimming.EllipsisCharacter
            };
            _gridPen = new Pen(Color.Black, 1);
            _totalWidth = 0;
            foreach (DataGridViewColumn col in _dgv.Columns)
                _totalWidth += col.Width;
            _printDoc.DefaultPageSettings.Landscape = true;

        }

        public void Print()
        {
            PrintDialog printDialog = new PrintDialog { Document = _printDoc };
            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                _currentRow = 0;
                _printDoc.Print();
            }
        }

        private void PrintPage(object sender, PrintPageEventArgs e)
        {
            float x = e.PageBounds.Left + 10;
            float y = e.PageBounds.Top + 8;
            float pageWidth = e.PageBounds.Width - 18;
            int columnCount = _dgv.Columns.Count;
            float colWidth = pageWidth / columnCount;

            float headerHeight = _dgv.ColumnHeadersHeight;
            float maxHeaderHeight = headerHeight;

            foreach (DataGridViewColumn col in _dgv.Columns)
            {
                SizeF textSize = e.Graphics.MeasureString(col.HeaderText, _dgv.Font, (int)colWidth);
                maxHeaderHeight = Math.Max(maxHeaderHeight, textSize.Height + 10);
            }

            foreach (DataGridViewColumn col in _dgv.Columns)
            {
                e.Graphics.FillRectangle(Brushes.LightGray, x, y, colWidth, maxHeaderHeight);
                e.Graphics.DrawRectangle(_gridPen, x, y, colWidth, maxHeaderHeight);
                e.Graphics.DrawString(col.HeaderText, _dgv.Font, Brushes.Black, 
                    new RectangleF(x, y, colWidth, maxHeaderHeight), _strFormat);
                x += colWidth;
            }

            y += maxHeaderHeight;

            while (_currentRow < _dgv.Rows.Count)
            {
                DataGridViewRow row = _dgv.Rows[_currentRow];
                x = e.PageBounds.Left + 10;
                float rowHeight = row.Height;

                foreach (DataGridViewCell cell in row.Cells)
                {
                    SizeF textSize = e.Graphics.MeasureString(Convert.ToString(cell.Value), _dgv.Font, (int)colWidth);
                    rowHeight = Math.Max(rowHeight, textSize.Height + 5);
                }

                foreach (DataGridViewCell cell in row.Cells)
                {
                    e.Graphics.DrawRectangle(_gridPen, x, y, colWidth, rowHeight);
                    e.Graphics.DrawString(Convert.ToString(cell.Value), _dgv.Font, Brushes.Black,
                        new RectangleF(x, y, colWidth, rowHeight), _strFormat);
                    x += colWidth;
                }

                y += rowHeight;
                _currentRow++;
                if (y + rowHeight > e.PageBounds.Bottom - 10)
                {
                    e.HasMorePages = true;
                    return;
                }
            }
            e.HasMorePages = false;
        }
    }