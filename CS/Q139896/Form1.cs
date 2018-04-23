using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraNavBar;

namespace Q139896 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            prevExpandedWidth = navBarControl1.Width;
        }
        private int prevExpandedWidth;

        private void splitterControl1_SplitterMoved(object sender, SplitterEventArgs e) {
            if (navBarControl1.Width <= 50) {
                if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Expanded) {
                    navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Collapsed;
                    navBarControl1.OptionsNavPane.ExpandedWidth = prevExpandedWidth;
                }
            } else
                if (navBarControl1.OptionsNavPane.NavPaneState == NavPaneState.Collapsed) {
                    navBarControl1.OptionsNavPane.NavPaneState = NavPaneState.Expanded;
                } else prevExpandedWidth = navBarControl1.Width;
        }
    }
}