using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DotSpatial.Controls;
using DotSpatial.Symbology;


namespace MapTest01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.AddLayer();
        }

        private void splcMapLegend_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                MapPolygonLayer startLayer = default(MapPolygonLayer);
                startLayer = (MapPolygonLayer)map1.Layers[0];
                if (startLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    map1.AddLabels(startLayer, "[State_NAME]", new Font("Tahoma", (float)8.0), Color.Black);
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnFilterByPopState_Click(object sender, EventArgs e)
        {
            //check the number of layers from map control

            if (map1.Layers.Count > 0)
            {
                //Delacre a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //Type cast the FirstLayer of MapControl to MapPolygonLayer
                stateLayer = (MapPolygonLayer)map1.Layers[0];

                //Check the MapPolygonLayer ( Make sure that it has a polygon layer)
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");

                }
                else
                {
                    //!!!-------------------- this line is necessary otherwise the code doesn't work------------------------!!!!!!!!!!!!!!!!!!!!

                }
                stateLayer.DataSet.FillAttributes();

                //Create a new PolygonScheme
                PolygonScheme scheme = new PolygonScheme();

                //Create a new PolygonCategory
                PolygonCategory category = new PolygonCategory(Color.Yellow, Color.Red, 1);

                //Declare a filter string
                //[POP1990],[STATE_NAME] are attributes from the attribute table of the given shape file.

                string filter = "[POP1990] > 10000000 OR [STATE_NAME] = 'Idaho'";

                //Set/Assign the filter expression to PolygonCategory
                category.FilterExpression = filter;

                //Set the Legend Text
                category.LegendText = "population > 10 Million";

                //Add the PolygonCategory in to the PolygonScheme
                scheme.AddCategory(category);

                //Set the scheme in to the MapPolygonLayer's symbology
                stateLayer.Symbology = scheme;
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void btnRandomColors_Click(object sender, EventArgs e)
        {

        }

        private void btnViewAttributes_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count>0)
            {
                MapPolygonLayer startlayer = default(MapPolygonLayer);
                startlayer = (MapPolygonLayer)map1.Layers[0];
                if (startlayer == null)
                {
                    MessageBox.Show("This is not a polygon !");
                }
                else
                {
                   DataTable dt = startlayer.DataSet.DataTable;
                    dgvAttributeTable.DataSource = dt;
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to map.");
            }
        }

        private void btnFilterByPopulation_Click(object sender, EventArgs e)
        {

        }

        private void lblPopulation_Click(object sender, EventArgs e)
        {

        }

        private void txtPopulation_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void clearMapCtrlCToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ClearLayers();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to exit?", "Admin", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void zoomInCtrlIToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomIn();
        }

        private void zoomOutCtrlOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomOut();
        }

        private void zoomExtendCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            map1.ZoomToMaxExtent();
        }

        private void btnFilterByStateName_Click(object sender, EventArgs e)
        {
            if (map1.Layers.Count > 0)
            {
                //Declare a MapPolygonLayer
                MapPolygonLayer stateLayer = default(MapPolygonLayer);

                //TypeCast the first layer from MapControl to MapPolygonLayer.
                //Layers are 0 based, therefore 0 is going to grab the first layer from the MapControl
                stateLayer = (MapPolygonLayer)map1.Layers[0];

                //Check whether stateLayer is polygon layer or not
                if (stateLayer == null)
                {
                    MessageBox.Show("The layer is not a polygon layer.");
                }
                else
                {
                    //SelectByAttribute method is used to implement the filter operations.
                    //In this example, STATE_NAME is used implement the filter operation
                    //We can see the IdhoSate on the map
                    stateLayer.SelectByAttribute("[STATE_NAME] = 'Idaho'");
                }
            }
            else
            {
                MessageBox.Show("Please add a layer to the map.");
            }
        }

        private void dgvAttributeTable_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dgvAttributeTable.SelectedRows)
            {
                MapPolygonLayer startLayer = default(MapPolygonLayer);
                startLayer = (MapPolygonLayer)map1.Layers[0];
                if (startLayer == null)
                { MessageBox.Show("The layer is not a polygon layer."); }
                else
                {
                    startLayer.SelectByAttribute("[STATE_NAME] =" + "'" + row.Cells["STATE_NAME"].Value + "'");
                }

            }
        }
    }
}
