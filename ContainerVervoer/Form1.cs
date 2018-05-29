using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Forms;
using ContainerVervoer.Models;

namespace ContainerVervoer
{
    public partial class ContainerVervoer : Form
    {
        private Service _service;
        private readonly List<Container> _containers;
        private int _count;

        public ContainerVervoer()
        {
            _containers = new List<Container>();
            InitializeComponent();

            BtnAdd.Enabled = false;
            BtnBegin.Enabled = false;
        }

        private void BtnAdd_Click(object sender, System.EventArgs e)
        {
            var weight = Convert.ToDouble(ndContainerWeight.Value);
            var valuable = rbValuable.Checked;
            var cooled = rbCooled.Checked;       
            
            // Making container
            var container = new Container(valuable, cooled, weight);
            _containers.Add(container);

            // Visualise container
            lbContainers.Items.Add(container.ToString());
            _count++;
            lblCount.Text = _count.ToString();
            BtnBegin.Enabled = true;
        }

        private void BtnSet_Click(object sender, System.EventArgs e)
        {
            var weight = ndShipWeight.Value;
            _service = new Service(6, Convert.ToDouble(weight));

            BtnAdd.Enabled = true;
            BtnSet.Enabled = false;
        }

        private void BtnBegin_Click(object sender, System.EventArgs e)
        {
            try { _service.QuickChecker(_containers); }
            catch (ExceptionHandler exceptionHandler) { rbxLog.Text = exceptionHandler.Message; return; }
            rbxLog.Text = @"Started..";

            try { _service.SetContainers(_containers); }
            catch (ExceptionHandler exceptionHandler) { rbxLog.Text = exceptionHandler.Message; return; }

            lbPlace1.DataSource = _service.GetPlaces()[0].Containers;
            lbPlace2.DataSource = _service.GetPlaces()[1].Containers;
            lbPlace3.DataSource = _service.GetPlaces()[2].Containers;
            lbPlace4.DataSource = _service.GetPlaces()[3].Containers;
            lbPlace5.DataSource = _service.GetPlaces()[4].Containers;
            lbPlace6.DataSource = _service.GetPlaces()[5].Containers;

            lblFullWeight.Text = Convert.ToString(_service.CalculateWeight(), CultureInfo.InvariantCulture);
            lblBalance.Text = Convert.ToString(_service.GetShipBalance(), CultureInfo.InvariantCulture);

            BtnBegin.Enabled = false;
            BtnAdd.Enabled = false;
            BtnDelete.Enabled = false;

            rbxLog.Text = @"Done! Reset to start again.";
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            var index = lbContainers.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show(@"Please select container");
                return;
            }
            lbContainers.Items.RemoveAt(index);
            _containers.RemoveAt(index);
            _count--;
            lblCount.Text = _count.ToString();
        }

        private void TsmiFileReset_Click(object sender, System.EventArgs e)
        {
            Application.Restart();
        }
    }
}