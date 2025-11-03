# Visualizing Power Consumption Trends with WPF Surface Charts

## Overview
Build an interactive Energy Analytics interface in WPF using [Syncfusion’s 3D Surface Chart](https://help.syncfusion.com/wpf/surface-chart/getting-started) to visualize annual per-capita energy consumption across countries and years.

## Why Surface Charts?
- Map three dimensions: **Year (X)**, **Consumption in MWh (Y)**, **Country (Z)**
- Continuous surface improves pattern and anomaly detection
- Color gradients highlight low-to-high consumption zones
- Interactive exploration via rotation, tilt, and zoom

## Why Syncfusion WPF?
- High-performance 3D rendering for large datasets
- Rich customization (axes, palettes, styles)
- MVVM-friendly bindings for clean architecture
- Built-in interactivity and surface-type switching
- Seamless integration with WPF UI components

## Data Model & Flow
- **AnnualEnergyStats**: Yearly values across multiple countries
- **EnergyDataPoint**: Flattened points for the surface grid

### ViewModel Responsibilities:
- Load yearly stats (e.g., 2015–2024 for Canada, France, India, UK, US)
- Convert to surface-ready points: `(Year, Country index, Consumption in MWh)`
- Expose grid dimensions via `RowSize` (years) and `ColumnSize` (countries)

## Interface Structure
- **Title**: Purpose-driven heading and subtitle
- **Main Chart**: 3D Surface Chart using a Year–Country grid with Consumption-driven height/color
- **Side Panel**:
  - Surface Type Selector (`WireframeSurface`, `Surface`)
  - Energy Usage Scale (legend mapping color to consumption)
  - Sustainability message with logo

## Interactivity
- Rotate, tilt, and zoom to inspect peaks and valleys
- Switch surface types to emphasize structure or magnitude
- Use the legend to decode intensity at a glance

![Energy Analytics interface]("https://github.com/user-attachments/assets/f94669dc-a790-4d60-b8c9-6ee2baae73f2")

## Troubleshooting

### Path Too Long Exception
If you encounter a “path too long” error when building the example project:

1. Close Visual Studio.
2. Rename the repository folder to a shorter name.
3. Reopen the solution and build again.

This reduces the full path length and resolves the exception.

Refer to the blog for step-by-step guidance on [Visualizing Power Consumption Trends with WPF Surface Charts]().
