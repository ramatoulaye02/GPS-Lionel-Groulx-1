# GPS Lionel-Groulx Navigation System

## 📍 Project Overview

This is an indoor GPS navigation system built with Unity for Collège Lionel-Groulx. The application provides real-time pathfinding and navigation within the school building, helping students, staff, and visitors find their way through multiple floors and corridors.

The system uses advanced pathfinding algorithms (A* and Dijkstra) to calculate optimal routes between locations, with support for custom constraints such as avoiding specific areas or passing through waypoints.

## ✨ Key Features

### Navigation & Pathfinding
- **Multiple Pathfinding Algorithms**: Implementation of both A* and Dijkstra algorithms for route calculation
- **Multi-Floor Navigation**: Support for navigating across different floors (Étage 1, 2, and 4)
- **Real-time GPS Integration**: Integration with device GPS for outdoor positioning
- **Indoor Navigation**: Custom node-based system for indoor navigation
- **Custom Constraints**: 
  - Avoid specific nodes/areas
  - Pass through specific waypoints
  - Multiple constraint combinations

### User Experience
- **3D Visualization**: Immersive 3D representation of the school building
- **First-Person Navigation**: First-person camera controls for realistic navigation experience
- **2D Map View**: Alternative 2D trajectory view for easier route understanding
- **User Instructions**: Step-by-step navigation guidance
- **Avatar Customization**: Personalized user avatars with customizable colors
- **Loading Screens**: Smooth transitions between scenes

### Technical Features
- **Graph-Based Architecture**: FloorGraph system for efficient path representation
- **Spline-Based Corridors**: Smooth corridor generation using spline mathematics
- **Dynamic Scene Loading**: Efficient loading system for different floors and areas
- **Teleportation Nodes**: Support for elevators and staircase transitions

## 🏗️ Project Structure

```
GPS-Lionel-Groulx-1/
├── Assets/
│   ├── Scenes/                    # Unity scenes for different views and floors
│   │   ├── MainScene.unity        # Main entry scene
│   │   ├── Navigation.unity       # Navigation interface
│   │   ├── Étage 1.unity         # Floor 1
│   │   ├── Étage 2.unity         # Floor 2
│   │   ├── Étage 4.unity         # Floor 4
│   │   ├── Trajet2D.unity        # 2D trajectory view
│   │   └── ...
│   ├── Scripts/                   # Core C# scripts
│   │   ├── AStarPathfinder.cs    # A* pathfinding implementation
│   │   ├── DjikstraPathfinder.cs # Dijkstra algorithm
│   │   ├── PathManager.cs        # Path management
│   │   ├── FloorGraph.cs         # Floor graph structure
│   │   ├── Node.cs               # Navigation node
│   │   ├── École.cs              # School data structure
│   │   ├── GeoLocalisation.cs    # GPS integration
│   │   ├── Avatar.cs             # User avatar
│   │   └── ...
│   ├── RessourcesGPS/            # GPS and navigation data
│   │   └── DataNodes/            # Node data files
│   │       ├── InsideData.txt    # Indoor navigation nodes
│   │       ├── OutsideData.txt   # Outdoor navigation nodes
│   │       ├── Nodes.txt         # General nodes
│   │       └── DataSpline.txt    # Spline data
│   ├── Prefabs/                  # Reusable Unity prefabs
│   ├── Materials/                # 3D materials
│   ├── Textures/                 # Textures and images
│   └── ...
├── ProjectSettings/              # Unity project settings
└── Packages/                     # Unity package dependencies
```

## 🛠️ Technical Stack

### Unity Version
- **Unity 2021.3.16f1**

### Core Dependencies
- **TextMesh Pro** (3.0.6) - Advanced text rendering
- **Unity Input System** (1.4.4) - Modern input handling
- **Unity Visual Scripting** (1.7.8) - Visual programming support
- **Unity Timeline** (1.6.4) - Cinematic and sequencing tools

### Programming Language
- **C#** - All game logic and systems

### Key Algorithms & Systems
- **A* Pathfinding**: Heuristic-based pathfinding for optimal routes
- **Dijkstra's Algorithm**: Alternative pathfinding approach
- **Graph Theory**: Node-based navigation graph
- **GPS Coordinate System**: Real-world coordinate mapping
- **Spline Mathematics**: Smooth corridor and path generation

## 📊 Data Format

The navigation system uses text-based data files to define navigation nodes:

### Node Data Format (InsideData.txt/OutsideData.txt)
```
[Latitude],[Longitude]@[Connections]	[Name]
```

Example:
```
45,6414369@-73,8423377	EscaliersN
45,6414728@-73,8422646	DevantEscaliersN
45,6414104@-73,8421392	CouloirN1,CouloirN2
```

## 🚀 Getting Started

### Prerequisites
- Unity 2021.3.16f1 or compatible version
- A device with GPS capability (for outdoor navigation testing)
- Basic knowledge of Unity Editor

### Installation

1. **Clone the Repository**
   ```bash
   git clone https://github.com/ramatoulaye02/GPS-Lionel-Groulx-1.git
   cd GPS-Lionel-Groulx-1
   ```

2. **Open in Unity**
   - Launch Unity Hub
   - Click "Open" and select the project directory
   - Unity will automatically import all assets and dependencies

3. **Configure Build Settings**
   - Go to File > Build Settings
   - Select your target platform (Windows, Mac, Linux, iOS, or Android)
   - Ensure all required scenes are added to the build

### Running the Project

1. **In Unity Editor**
   - Open `Assets/Scenes/MainScene.unity`
   - Press the Play button in the Unity Editor

2. **Build and Run**
   - Go to File > Build Settings
   - Click "Build and Run"
   - Select output location for the executable

## 🎮 Usage

### Basic Navigation Flow

1. **Start Screen**: Launch the application from the main menu
2. **Select Destination**: Choose your target location from the destination menu
3. **Choose Constraints** (Optional): 
   - Select areas to avoid
   - Choose waypoints to pass through
4. **View Route**: The system calculates and displays the optimal path
5. **Navigate**: Follow the visual guidance and instructions
6. **Switch Views**: Toggle between 3D first-person and 2D map views

### Navigation Modes

- **First Person Mode**: Immersive 3D navigation with realistic camera controls
- **2D Map Mode**: Bird's-eye view of your route on a floor plan
- **Avatar Mode**: Customize your navigation avatar

## 🏛️ Architecture Overview

### Core Systems

1. **École (School) System**
   - Manages the entire school building structure
   - Coordinates multiple floors (FloorGraph)
   - Handles outdoor and indoor areas (Ailes - wings)
   - Processes navigation data from text files

2. **Pathfinding System**
   - Abstract `Pathfinder` base class
   - Concrete implementations: `AStarPathfinder`, `DjikstraPathfinder`
   - Support for constraints and waypoints
   - Returns optimal `Path` based on algorithm

3. **Node System**
   - `Node`: Basic navigation point with GPS coordinates
   - `PathfindingNode`: Enhanced node with traversability and connections
   - `TeleportingNode`: Special nodes for floor transitions (stairs, elevators)
   - `UserMovementNode`: Nodes for user interaction

4. **Graph System**
   - `FloorGraph`: Represents a single floor's navigation graph
   - Graph-based representation for efficient pathfinding
   - Manages node connections and relationships

5. **Geolocation System**
   - `GeoLocalisation`: Integrates device GPS
   - `GPSCoordinate`: Coordinate conversion and management
   - Real-world to Unity coordinate mapping

## 🗺️ Floor Structure

The school is represented with the following floors:
- **Étage 1** (Floor 1): Ground level
- **Étage 2** (Floor 2): Second level  
- **Étage 4** (Floor 4): Fourth level

Each floor has its own:
- Navigation graph
- Unity scene
- Set of navigation nodes
- Corridor systems

## 👥 User Features

### Avatar System
- Customizable username
- Color personalization
- Persistent user preferences

### Constraints System
Users can set navigation constraints:
- **Avoid Nodes**: Skip specific areas (e.g., crowded hallways)
- **Waypoint Nodes**: Must pass through specific points
- **Combined Constraints**: Multiple avoidance and waypoint combinations

## 📱 Platform Support

The project is configured to support:
- Windows Desktop
- macOS
- Linux
- iOS (with GPS support)
- Android (with GPS support)

## 🔧 Development

### Adding New Navigation Nodes

1. Edit the appropriate data file in `Assets/RessourcesGPS/DataNodes/`
2. Add node in format: `[GPS Coordinates]	[Name]`
3. Update connections between nodes
4. Reload the scene in Unity

### Modifying Pathfinding

The pathfinding system is modular:
- Extend the `Pathfinder` abstract class
- Implement your custom algorithm
- Register in the `PathManager`

### Adding New Floors

1. Create a new Unity scene
2. Build the 3D environment
3. Define navigation nodes in data files
4. Add `FloorGraph` entry in the École system
5. Update scene transitions

## 🐛 Troubleshooting

### GPS Not Working
- Ensure location services are enabled on your device
- Check that the app has location permissions
- The system waits up to 20 seconds for GPS initialization

### Path Not Found
- Verify that all nodes are properly connected in data files
- Check that no required nodes are marked as non-traversable
- Ensure destination is reachable from starting point

### Scene Loading Issues
- Verify all scenes are added in Build Settings
- Check that scene names match the loading scripts
- Ensure Loading scene is properly configured

## 📝 License

This project is developed for educational purposes at Collège Lionel-Groulx.

## 🤝 Contributing

This is an educational project. For questions or contributions:
1. Fork the repository
2. Create a feature branch
3. Submit a pull request with detailed description

## 📧 Contact

For questions or support regarding this navigation system, please contact the development team at Collège Lionel-Groulx.

## 🙏 Acknowledgments

- Collège Lionel-Groulx for project sponsorship
- Unity Technologies for the development platform
- Contributors to the navigation system development

---

**Last Updated**: February 2026  
**Version**: 1.0  
**Unity Version**: 2021.3.16f1
