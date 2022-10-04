using FlameFTP.Controls.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlameFTP.Controls {
	public partial class ColoredLog : UserControl {

		private List<LogItem> LogData = new List<LogItem>();
		public int MaxItemCount { get; set; } = 500;

		public ColoredLog() {
			InitializeComponent();
		}

		public ColoredLog(IContainer container) {
			container.Add(this);

			InitializeComponent();

			if (!DesignMode) {
				LstLog.DrawMode = DrawMode.OwnerDrawFixed;
			}
		}
		public void AddItem(string text, Color textColor, object tag) {

			var item = new LogItem {
				Text = text,
				Tag = tag,
				TextColor = textColor,
				TextBrush = new SolidBrush(textColor),
			};

			LogData.Add(item);
			if (LogData.Count >= MaxItemCount) {
				LogData.RemoveAt(0);
			}

			LstLog.Items.Add(text);
			if (LstLog.Items.Count >= MaxItemCount) {
				LstLog.Items.RemoveAt(0);
			}

			LstLog.SelectedIndex = LstLog.Items.Count - 1;
		}

		private void LstLog_DrawItem(object sender, DrawItemEventArgs e) {

			// Get the log item metadata
			var item = LogData[e.Index];

			// Draw the background for each item
			e.DrawBackground();

			// Draw the current item text with the chosen color
			e.Graphics.DrawString(((ListBox)sender).Items[e.Index].ToString(),
				e.Font, item.TextBrush, e.Bounds, StringFormat.GenericDefault);

			// If the ListBox has focus, draw a focus rectangle around the selected item
			e.DrawFocusRectangle();

		}

	}
}