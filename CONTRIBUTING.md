# Contributing Guidelines

## GUI Control Standardization

### Form Size Standards
- **Standard Form Size**: `ClientSize = new Size(1587, 950)` (Width: 1587, Height: 950)
- **AutoScaleDimensions**: `new SizeF(17F, 41F)`
- **AutoScaleMode**: `AutoScaleMode.Font`

### Button Standards
- **Header/Top Bar Buttons**:
  - Height: 63 pixels
  - First button (Add): `Location = new Point(12, 12)`, `Size = new Size(375, 63)`
  - Second button (Edit): `Location = new Point(393, 12)`, `Size = new Size(402, 63)`
  - Third button (Delete): `Location = new Point(801, 12)`, `Size = new Size(421, 63)`
  - Fourth button (Refresh): `Location = new Point(1228, 12)`, `Size = new Size(347, 63)`
  - Panel Height: 102 pixels
  
- **Form Action Buttons** (Save/Cancel):
  - Height: 64 pixels
  - Width: Divided equally (typically 466-457 for 2 buttons in a panel)
  - Location Y: 778 pixels from panel top

### TextBox Standards
- **Standard Height**: 47 pixels
- **Standard Width**: 929 pixels (in detail panels)
- **Margin/Padding**: 6 pixels from left edge

### ComboBox Standards
- **Standard Height**: 49 pixels
- **Standard Width**: 929 pixels (in detail panels)
- **Margin/Padding**: 6 pixels from left edge

### Label Standards
- **Label Height**: 46 pixels
- **Label Width**: 314 pixels (for field labels)
- **Margin/Padding**: 6 pixels from left edge
- **Vertical Spacing**: 49 pixels (46 height + 3 pixel gap between label and control)

### DataGridView Standards
- **ColumnHeadersHeight**: 58 pixels
- **RowHeadersWidth**: 102 pixels
- **Default Docking**: `DockStyle.Left` for left panel, `DockStyle.Fill` for right panel

### Panel Standards
- **Header Panel** (Top Bar):
  - Dock: Top
  - Height: 102 pixels
  - Location: `new Point(0, 0)`

- **Details Panel** (Right Side):
  - Dock: Fill
  - Location: `new Point(640, 102)`
  - Width: ~947 pixels

- **Status Panel** (Bottom Bar):
  - Dock: Bottom
  - Height: 102 pixels (consistent with header)

### GroupBox Standards
- **GroupBox Container** (Left Panel - List):
  - Width: ~640 pixels
  - Height: Calculated to fill available space
  - Margin: 0 pixels (Dock: Left)

- **GroupBox Container** (Right Panel - Details):
  - Width: ~947 pixels
  - Height: Calculated to fill available space
  - Margin: 0 pixels (Dock: Fill)

### Spacing & Padding Standards
- **Horizontal Padding**: 6 pixels from panel edges
- **Vertical Padding**: 12 pixels (button row), 6 pixels (control row)
- **Control Spacing**: 49 pixels between controls vertically (label + textbox height + gap)
- **Margin**: `new Padding(6, 8, 6, 8)` for containers

### Naming Conventions for Controls
- Buttons: `btn_<formName><ActionName>` (e.g., `btn_categoryAdd`)
- TextBox: `txt_<fieldName>` (e.g., `txt_categoryName`)
- ComboBox: `cbb_<fieldName>` (e.g., `cbb_categoryStatus`)
- DataGridView: `dgv_<listName>` (e.g., `dgv_suppliers`)
- Label: `lbl_<labelName>` (e.g., `lbl_supplierName`)
- Panel: `pnl_<purpose>` (e.g., `pnl_header`)
- GroupBox: `groupBox<Number>` or descriptive name

### Implementation Guidelines
1. **All Forms** must follow the standard Form size (1587 x 950)
2. **All buttons** in header/top bar must maintain consistent height (63 px) and positioning
3. **All textboxes** must be 929 pixels wide when in detail panels
4. **All labels** must be 314 pixels wide for field descriptions
5. **Consistent margins** and padding across all forms
6. Use `new Padding(6, 8, 6, 8)` for form-level margins
7. Never hardcode colors - use SystemColors where possible
8. Use DockStyle for panel layouts to ensure responsive design

### Example Control Layout
```
Form (1587 x 950)
??? Panel Header/TopBar (Dock: Top, Height: 102)
?   ??? Button Add (Point: 12, 12; Size: 375, 63)
?   ??? Button Edit (Point: 393, 12; Size: 402, 63)
?   ??? Button Delete (Point: 801, 12; Size: 421, 63)
?   ??? Button Refresh (Point: 1228, 12; Size: 347, 63)
??? Panel/GroupBox List (Dock: Left, Width: 640)
?   ??? DataGridView (Headers: 58px, RowHeaders: 102px)
??? Panel/GroupBox Details (Dock: Fill)
?   ??? Label (Point: 6, Y; Size: 314, 46)
?   ??? TextBox/ComboBox (Point: 6, Y+49; Size: 929, 47/49)
?   ??? Button Save (Point: 6, 778; Size: 466, 64)
?   ??? Button Cancel (Point: 478, 778; Size: 457, 64)
??? Panel Status (Dock: Bottom, Height: 102)
    ??? Label Summary
```

## Code Standards
- C# version: 13.0
- .NET target: .NET 9
- Use nullable reference types (nullable annotations enabled)
- Use pattern matching and modern C# features appropriately