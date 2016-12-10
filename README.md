# PCB-Driller
This contains the c# code for a PCB(Printed Circuit Board) driller.

Application will take a PCB schematic diagram, convert it to a black and white image and analyse it using a circle identification algorithm. Once the required shape (circle) is found it'll calculate the diameter and the center point of the drilling position.

Once all points are calculated you can save the data in to a file. The application also finds the path to drill points using an algorithm for finding the shortest path.

Project is not complete. Only the software part is implemented. 
Error handling in the code is not complete. 
Algorithms can be optimized further.
