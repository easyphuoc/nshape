using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Dataweb.nShape.Advanced;
using System.Data.SqlClient;


namespace Dataweb.nShape.Designer {

	public partial class OpenAdoNetRepositoryDialog : Form {

		public OpenAdoNetRepositoryDialog() {
			InitializeComponent();
		}


		public string ProjectName {
			get { return projectNameTextBox.Text; }
		}

		
		private void OpenAdoNetRepositoryDialog_Load(object sender, EventArgs e) {
			serverNameTextBox.Text = Environment.MachineName;
			databaseNameTextBox.Text = "nShape";
		}
	}
}