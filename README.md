# La Vanille Wild Lens

La Vanille Wild Lens is a prototype of an Augmented Reality mobile application built using an Augmented Reality development tool (Unity + Vuforia) to enhance the visiting experience at La Vanille Nature Park.

![MenuScreen](images/MenuScreen.JPG)

The application was developed on `MacOS Sonoma 14.2.1` and tested on an android device version `11`.

## Technologies Used

- Unity Hub 3.7.0
- Unity 2022.3.16f1
- Vuforia Engine 10.20

## Installation

1. Clone the repository
2. Open the project in Unity Hub
3. Open the `MainScene` scene in the `Assets/DataFiles/Scenes` folder
4. Build and Run the application on an android device

## Create a new Object Model Target

1. Download Polycam (<https://poly.cam/>) on your mobile device.
2. Use Photo Mode on your device to get instant, accurate 3D models.
3. Export the 3D model as an `.obj` file.
4. Download Vuforia Model Target Generator (<https://developer.vuforia.com/downloads/tool>) on your computer.
5. In Vuforia Model Target Generator, create a new model target and import the `.obj` file.
6. Create a new Advanced MT Database and add the model target to the database. This will take approximately 2 hours.
7. Download the database and import it into the Unity project.

Reference:

1. <https://youtu.be/7n-1XCUgbfM>
2. <https://youtu.be/yW3iLmn7IG8>

## Screenshots

![Crocodile](images/Crocodile.JPG)
![Butterfly](images/Butterfly.JPG)
![Wasp](images/Wasp.JPG)
