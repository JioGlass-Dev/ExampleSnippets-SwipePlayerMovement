# Swipe Player Movement
Example of implementing swipe based player movement

## Scripts 

### [`SwipePlayerMovement.cs`](https://github.com/JioGlass-Dev/ExampleSnippets-SwipePlayerMovement/blob/main/Assets/Scripts/JMRSDKExampleSnippets/SwipePlayerMovement.cs)
Shows example of moving the player on controller swipe.</br>
- Interfaces to implement swipe funtionality
```cs
public class SwipePlayerMovement : MonoBehaviour, ISwipeHandler
```
- Methods to implement swipe funtionality
```cs
public void OnSwipeUp(SwipeEventData eventData, float value)
{ }
public void OnSwipeDown(SwipeEventData eventData, float value)
{ }
public void OnSwipeLeft(SwipeEventData eventData, float value)
{ }
public void OnSwipeRight(SwipeEventData eventData, float value)
{ }
public void OnSwipeStarted(SwipeEventData eventData)
{ }
public void OnSwipeUpdated(SwipeEventData eventData, Vector2 swipeData)
{ }
public void OnSwipeCompleted(SwipeEventData eventData)
{ }
public void OnSwipeCanceled(SwipeEventData eventData)
{ }
```

## How to use?
1. Download and unzip this project.
2. Open the project using Unity Hub.
3. Download and import the latest version of JMRSDK package.
4. Open and play the SwipePlayerMovement scene from Assets/Scenes folder.
