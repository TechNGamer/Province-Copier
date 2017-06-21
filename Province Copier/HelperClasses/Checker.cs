using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ProvinceCopier.HelperClasses {
	class Checker {
		public Thread transferThread;
		public Button startButton;

		public void DisableStartButton() {
			while( transferThread.IsAlive ) {
				startButton.Enabled = false;
			}
			startButton.Enabled = true;
		}
	}
}
