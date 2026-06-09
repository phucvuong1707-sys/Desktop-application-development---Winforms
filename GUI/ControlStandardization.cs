using System;
using System.Drawing;
using System.Windows.Forms;

namespace GUI
{
    /// <summary>
    /// Utility class để chuẩn hóa kích thước và vị trí các control trong GUI
    /// Tuân theo CONTRIBUTING.md standards
    /// </summary>
    public static class ControlStandardization
    {
        // ========== FORM STANDARDS ==========
        public static readonly Size StandardFormSize = new Size(1587, 950);
        public static readonly SizeF StandardAutoScaleDimensions = new SizeF(17F, 41F);
        public static readonly AutoScaleMode StandardAutoScaleMode = AutoScaleMode.Font;

        // ========== BUTTON STANDARDS ==========
        // Top Bar Buttons
        public static readonly int ButtonTopBarHeight = 63;
        public static readonly int ButtonTopBarAddWidth = 375;
        public static readonly int ButtonTopBarEditWidth = 402;
        public static readonly int ButtonTopBarDeleteWidth = 421;
        public static readonly int ButtonTopBarRefreshWidth = 347;

        public static readonly Point ButtonTopBarAddLocation = new Point(12, 12);
        public static readonly Point ButtonTopBarEditLocation = new Point(393, 12);
        public static readonly Point ButtonTopBarDeleteLocation = new Point(801, 12);
        public static readonly Point ButtonTopBarRefreshLocation = new Point(1228, 12);

        // Form Action Buttons (Save/Cancel)
        public static readonly int ButtonFormActionHeight = 64;
        public static readonly int ButtonFormActionSaveWidth = 466;
        public static readonly int ButtonFormActionCancelWidth = 457;
        public static readonly int ButtonFormActionY = 778;

        // ========== TEXTBOX STANDARDS ==========
        public static readonly int TextBoxHeight = 47;
        public static readonly int TextBoxWidth = 929;
        public static readonly int TextBoxMarginLeft = 6;

        // ========== COMBOBOX STANDARDS ==========
        public static readonly int ComboBoxHeight = 49;
        public static readonly int ComboBoxWidth = 929;
        public static readonly int ComboBoxMarginLeft = 6;

        // ========== LABEL STANDARDS ==========
        public static readonly int LabelHeight = 46;
        public static readonly int LabelWidth = 314;
        public static readonly int LabelMarginLeft = 6;
        public static readonly int LabelVerticalSpacing = 49; // 46 + 3 gap

        // ========== DATAGRIDVIEW STANDARDS ==========
        public static readonly int DataGridViewColumnHeadersHeight = 58;
        public static readonly int DataGridViewRowHeadersWidth = 102;

        // ========== PANEL STANDARDS ==========
        public static readonly int PanelHeaderHeight = 102;
        public static readonly int PanelStatusHeight = 102;
        public static readonly int PanelLeftWidth = 640;
        public static readonly int PanelRightWidth = 947;

        // ========== MARGIN/PADDING STANDARDS ==========
        public static readonly Padding StandardMargin = new Padding(6, 8, 6, 8);
        public static readonly Padding StandardPadding = new Padding(6);

        // ========== HELPER METHODS ==========

        /// <summary>
        /// Áp dụng tiêu chuẩn Form: kích thước, AutoScaleDimensions, AutoScaleMode
        /// </summary>
        public static void ApplyFormStandard(Form form)
        {
            form.ClientSize = StandardFormSize;
            form.AutoScaleDimensions = StandardAutoScaleDimensions;
            form.AutoScaleMode = StandardAutoScaleMode;
            form.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho Top Bar Button
        /// </summary>
        public static void ApplyTopBarButtonStandard(Button button, ButtonPosition position)
        {
            button.Height = ButtonTopBarHeight;
            button.Margin = StandardMargin;

            switch (position)
            {
                case ButtonPosition.Add:
                    button.Location = ButtonTopBarAddLocation;
                    button.Width = ButtonTopBarAddWidth;
                    break;
                case ButtonPosition.Edit:
                    button.Location = ButtonTopBarEditLocation;
                    button.Width = ButtonTopBarEditWidth;
                    break;
                case ButtonPosition.Delete:
                    button.Location = ButtonTopBarDeleteLocation;
                    button.Width = ButtonTopBarDeleteWidth;
                    break;
                case ButtonPosition.Refresh:
                    button.Location = ButtonTopBarRefreshLocation;
                    button.Width = ButtonTopBarRefreshWidth;
                    break;
            }
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho Form Action Button (Save/Cancel)
        /// </summary>
        public static void ApplyFormActionButtonStandard(Button button, bool isSaveButton)
        {
            button.Height = ButtonFormActionHeight;
            button.Margin = StandardMargin;
            button.Location = new Point(isSaveButton ? 6 : 478, ButtonFormActionY);
            button.Width = isSaveButton ? ButtonFormActionSaveWidth : ButtonFormActionCancelWidth;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho Top Bar Panel
        /// </summary>
        public static void ApplyTopBarPanelStandard(Panel panel)
        {
            panel.Dock = DockStyle.Top;
            panel.Height = PanelHeaderHeight;
            panel.Location = new Point(0, 0);
            panel.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho Status Panel
        /// </summary>
        public static void ApplyStatusPanelStandard(Panel panel)
        {
            panel.Dock = DockStyle.Bottom;
            panel.Height = PanelStatusHeight;
            panel.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho TextBox
        /// </summary>
        public static void ApplyTextBoxStandard(TextBox textBox, int yPosition)
        {
            textBox.Height = TextBoxHeight;
            textBox.Width = TextBoxWidth;
            textBox.Location = new Point(TextBoxMarginLeft, yPosition);
            textBox.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho ComboBox
        /// </summary>
        public static void ApplyComboBoxStandard(ComboBox comboBox, int yPosition)
        {
            comboBox.Height = ComboBoxHeight;
            comboBox.Width = ComboBoxWidth;
            comboBox.Location = new Point(ComboBoxMarginLeft, yPosition);
            comboBox.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho Label
        /// </summary>
        public static void ApplyLabelStandard(Label label, int yPosition)
        {
            label.Height = LabelHeight;
            label.Width = LabelWidth;
            label.Location = new Point(LabelMarginLeft, yPosition);
            label.Margin = StandardMargin;
        }

        /// <summary>
        /// Áp dụng tiêu chuẩn cho DataGridView
        /// </summary>
        public static void ApplyDataGridViewStandard(DataGridView dgv)
        {
            dgv.ColumnHeadersHeight = DataGridViewColumnHeadersHeight;
            dgv.RowHeadersWidth = DataGridViewRowHeadersWidth;
        }

        /// <summary>
        /// Tính toán Y position của control dựa trên index (tính từ 0)
        /// Sử dụng cho việc xếp chồng các Label và TextBox/ComboBox
        /// </summary>
        public static int CalculateControlY(int rowIndex, int startY = 85)
        {
            return startY + (rowIndex * LabelVerticalSpacing);
        }
    }

    /// <summary>
    /// Enum để chỉ định vị trí của Top Bar Button
    /// </summary>
    public enum ButtonPosition
    {
        Add,
        Edit,
        Delete,
        Refresh
    }
}