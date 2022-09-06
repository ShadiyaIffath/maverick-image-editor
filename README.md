# MaverickImageEditor
A Windows Image Editor Tool implemented using the Task Parallel Library in .Net 4.0 with increased performance and responsivenes. The application does not freeze while in the middle of a task.

# Functionality

1. Upload and save image
2. Rotate image - The image is rotated as a whole clockwise or anticlockwise in a particular angle
3. Flip image - Flips the position of the elements of the image as a whole either horizontally or vertically 
4. Grayscale - This takes each pixel in the image and gets the average of the RGB value and replaces that particular pixel in that position with the average value calculated.
6. Change Brightness - The overall light or darkness of the image uploaded can either be changed to a dark version or light version of the original based on the value the user enters
7. Crop image
8. Invert filter - This gets value of each R,G,B value of every pixel and sets a new value which is the difference of the color type and 255 of every pixel
9. Contrast filter - This darkens shadowed pixels and brighten highlights that already there in each pixel by the value selected by the user
10. Sepia filter - This gets the R, G, B value of each pixel each hue has its own value to be calculated with and the new value is assigned to the pixel
11. Red Filter, Green Filter, Blue Filter - Each pixel value for R, G, B values are replaced with zero and depending on the filter selected, only the original value will be inserted to the pixel.
12. Undo, Redo functionality - Stack datastructures are used.


