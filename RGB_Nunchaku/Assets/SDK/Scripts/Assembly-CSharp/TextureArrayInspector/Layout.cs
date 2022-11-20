using UnityEngine;

namespace TextureArrayInspector
{
	public class Layout
	{
		public enum DragState
		{
			Pressed = 0,
			Drag = 1,
			Released = 2,
		}

		public enum DragSide
		{
			right = 0,
			left = 1,
			top = 2,
			bottom = 3,
			rightTop = 4,
			leftTop = 5,
			rightBottom = 6,
			leftBottom = 7,
		}

		public Rect field;
		public Rect cursor;
		public Rect lastRect;
		public int margin;
		public int rightMargin;
		public int lineHeight;
		public float bottomPoint;
		public int verticalPadding;
		public int horizontalPadding;
		public Object undoObject;
		public string undoName;
		public int repaintsLeft;
		public Vector2 scroll;
		public float zoom;
		public float zoomStep;
		public float minZoom;
		public float maxZoom;
		public int scrollButton;
		public bool change;
		public bool lastChange;
		public float fieldSize;
		public float sliderSize;
		public bool monitorChange;
		public bool markup;
		public bool useEvent;
		public bool disabled;
		public int fontSize;
		public int iconOffset;
		public bool dragChange;
		public bool slider;
		public bool delayed;
		public DragState dragState;
		public Rect dragRect;
		public Vector2 dragPos;
		public Vector2 dragDelta;
		public Vector2 dragOffset;
		public int dragId;
		public DragSide dragSide;
		public Rect dragInitialRect;
	}
}
