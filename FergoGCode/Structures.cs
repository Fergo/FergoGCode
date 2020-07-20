using System.Collections.Generic;

namespace FergoGCode {
	public enum GCodeType {
		SINGLE_PASS,
		MULTIPLE_PASS
	}

	public class Shape {
		public List<Vector2d> Vertices;

		public Shape() {
			this.Vertices = new List<Vector2d>();
		}

		public Shape(List<Vector2d> Vertices) {
			this.Vertices = Vertices;
		}
	}

	public class Vector2d {
		public double X;
		public double Y;

		public Vector2d(double X, double Y) {
			this.X = X;
			this.Y = Y;
		}
	}

	public class GCodeSettings {
		public string gcLaserOn;
		public string gcLaserOff;

		public string gcSpindleOn;
		public string gcSpindleOff;

		public string gcUnit;
		public string gcPositioning;

		public string gcHeader;
		public string gcFooter;

		public double gcZTravelHeight;
		public double gcZChange;
		public int gcPass;
		public bool gcRapidRaise;

		public int gcMoveFeed;
		public int gcLinearFeed;

		public string gcMoveFeedCmd;
		public string gcLinearFeedCmd;

		public GCodeType gcType;
		public string gcPrecisionFormat;
		public bool gcComments;
		public bool gcReturnOrigin;
		public bool gcIsSpindle;
	}

}
