# Fergo GCode

Fergo GCode is a simple utility to convert DXF (up to version 2010) or Gerber files into GCode.

### Objective

I decided to create this tool with some specific goals in mind:

- Cut materials with my CNC laser (which is actually my 3D printer with a laser attached to it).
- PCB milling, drilling and etching using Gerber files.
- Laser etching in general

### Screenshot

![Screenshot](https://raw.githubusercontent.com/Fergo/FergoGCode/master/screenshot.png "Screenshot")

### Functionalities

The tool is quite customizable in terms of GCode generation. Some functionalities include:

- Units selection
- Relative or absolute positioning
- Customizable laser/spindle on/off commands
- Customizable feed rates
- Add extra commands at the start or end of the process
- Multiple pass operation, with Z-height changes

The multiple passes are particularly useful for laser cutting if your laser is not powerful enough to do it in one single pass. It can change the Z height on each pass so the laser is always focused on the cutting surface.

### Operation

For my modded printer, the PWM signals that sets the laser/spindle power comes from the fan control of the 3D printer, so I use the "Fan On" GCode command for it (M106 SXXX). If you drive your laser/spindle in a different way, you can easily change the GCode command to use.

### Dependencies

**GerberTools Library** - https://github.com/ThisIsNotRocketScience/GerberTools

**Fergo SimpleDXF** - https://github.com/Fergo/simple-dxf

### Download

https://github.com/Fergo/FergoGCode/releases

### Attributions

Icon made by [Nikita Golubev](https://www.flaticon.com/authors/nikita-golubev) from [www.flaticon.com](https://www.flaticon.com/) 

