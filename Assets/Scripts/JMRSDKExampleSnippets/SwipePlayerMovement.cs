using UnityEngine;
using JMRSDK.InputModule;

/// <summary>
/// Sample for swipe based player movement
/// </summary>
namespace JMRSDKExampleSnippets.SwipePlayerMovement
{
	/// <summary>
	/// The SwipePlayerMovement class handles the functionality for making the player move using Swipe Actions. 
	/// </summary>
	public class SwipePlayerMovement : MonoBehaviour,ISwipeHandler
    {
        /// <summary>
        /// The reference to the JMRMixedReality GameObject in the scene
        /// </summary>
        [SerializeField] GameObject jMRMixedReality;
        /// <summary>
        /// The reference to the JMRRig GameObject in the Scene. The JMRRig is a child of JMRMixedReality
        /// </summary>
        [SerializeField] GameObject jMRRig;
        /// <summary>
        /// The speed of the movement of the player
        /// </summary>
        [SerializeField] float speed = 50f;

        Vector3 direction;

        void Start()
		{
			AddGlobalListener();
		}

        /// <summary>
        /// Adding a Global Listener to listen to swipe actions
        /// </summary>
		private void AddGlobalListener()
		{
			JMRInputManager.Instance.AddGlobalListener(gameObject);
		}

		/// <summary>
		/// Callback for Swipe Up Action in Trackpad
		/// </summary>
		/// <param name="eventData">Contains swipe details</param>
		/// <param name="value">Amount of swipe movement</param>
		public void OnSwipeUp(SwipeEventData eventData, float value)
        {
            MoveForward();
        }

        /// <summary>
        /// Handles Functionality for moving forward
        /// </summary>
        private void MoveForward()
        {
            direction = jMRRig.transform.forward * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position += direction;
        }

        /// <summary>
        /// Callback for Swipe Down Action in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        /// <param name="value">Amount of swipe movement</param>
        public void OnSwipeDown(SwipeEventData eventData, float value)
        {
            MoveBack();
        }

        /// <summary>
        /// Handles Functionality for moving back
        /// </summary>
        private void MoveBack()
        {
            direction = jMRRig.transform.forward * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position -= direction;
        }

        /// <summary>
        /// Callback for Swipe Left Action in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        /// <param name="value">Amount of swipe movement</param>
        public void OnSwipeLeft(SwipeEventData eventData, float value)
        {
            MoveLeft();
        }

        /// <summary>
        /// Handles functionality for moving left
        /// </summary>
        private void MoveLeft()
        {
            direction = jMRRig.transform.right * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position -= direction;
        }

        /// <summary>
        /// Callback for Swipe Right Action in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        /// <param name="value">Amount of swipe movement</param>
        public void OnSwipeRight(SwipeEventData eventData, float value)
        {
            MoveRight();
        }

        /// <summary>
        /// Handles functionality for moving right
        /// </summary>
        private void MoveRight()
        {
            direction = jMRRig.transform.right * speed * Time.deltaTime;
            direction.y = 0;

            jMRMixedReality.transform.position += direction;
        }

        /// <summary>
        /// Callback for Swipe Started Action in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        public void OnSwipeStarted(SwipeEventData eventData)
        {
            
        }

        /// <summary>
        /// Callback for Swipe Updated in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        /// <param name="swipeData">amount of swipe movement done in the previous frame</param>
        public void OnSwipeUpdated(SwipeEventData eventData, Vector2 swipeData)
        {
           
        }

        /// <summary>
        /// Callback for Swipe Cancelled in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        public void OnSwipeCanceled(SwipeEventData eventData)
        {

        }

        /// <summary>
        /// Callback for Swipe Completed in Trackpad
        /// </summary>
        /// <param name="eventData">Contains swipe details</param>
        public void OnSwipeCompleted(SwipeEventData eventData)
        {

        }
    }
}

