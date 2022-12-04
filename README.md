# GaugeMaui
A gauge/dial API using MAUI technology

# Summary
A simple multi-purpose control that can be used as a semi-circular or linear gauge. The component utilises the `Microsoft.Maui.Graphics` library. 

## Preview

![CurvedGauge_crop](https://user-images.githubusercontent.com/36523300/205498118-c4c8086d-e287-4112-973e-f4bd76c7b193.gif)   
---
![HorizontalSymmetricGauge_crop](https://user-images.githubusercontent.com/36523300/205498122-6c3c59b5-2f91-4a9f-a9e9-1cda1497cccc.gif)

# Bindable Properties
| Property | Description |
| -------- | ----------- |
| GaugeType | Layout type of the gauge e.g. `Curved`, `HorizontalSymmetric` |
| GaugeMinimum| Minimum value that the gauge shows |
| GaugeMaximum| Maximum value that the gauge shows |
| GaugeValue| Value that the gauge needs to show |
| GaugeColor | Color of the gauge indicating `GaugeValue`|
| LabelColor| Color of the label that represents `GaugeValue`|
| GaugeBackgroundColor | Color of the _trajectory_ on which the gauge indicates `GaugeValue` |
| IsLabelShown | Controls whether the label is visible on the gauge |
