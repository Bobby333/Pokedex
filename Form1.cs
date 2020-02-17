using System.Windows.Forms;
using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.VisualBasic.FileIO;
using System.Collections.Generic;

namespace pokemon
{

    public partial class Form1 : Form
    {

        Form2 stats = new Form2();
        string input = "";
        Boolean clicked = false;
        List<Class1> Pokedex = new List<Class1>();
        List<string> Galar = new List<string>();
        public Form1()
        {
            InitializeComponent();
            lstpokemon.View = View.Details;
            TheDex();
            foreach (var Item in Pokedex)
            {
                ListViewItem item1 = new ListViewItem(Item.DexNumber);
                item1.SubItems.Add(Item.Name);
                item1.SubItems.Add(Item.Type1);
                item1.SubItems.Add(Item.Type2);
                item1.SubItems.Add(Item.Total);
                item1.SubItems.Add(Item.HP);
                item1.SubItems.Add(Item.ATK);
                item1.SubItems.Add(Item.DEf);
                item1.SubItems.Add(Item.SpAtk);
                item1.SubItems.Add(Item.SpDef);
                item1.SubItems.Add(Item.Spd);
                item1.SubItems.Add(Item.Generation);
                item1.SubItems.Add(Item.Legendary);
                lstpokemon.Items.AddRange(new ListViewItem[] { item1 });

            }

        }

        void TheDex()
        {

            string[] delimiters = { ";", "," };
            using (TextFieldParser parser = FileSystem.OpenTextFieldParser("pokemon.csv", delimiters))
            {

                while (!parser.EndOfData)
                {
                    Class1 Dex = new Class1();

                    string[] fields = parser.ReadFields();
                    Dex.DexNumber = fields[0];
                    Dex.Name = fields[1];
                    Dex.Type1 = fields[2];
                    Dex.Type2 = fields[3];
                    Dex.Total = fields[4];
                    Dex.HP = fields[5];
                    Dex.ATK = fields[6];
                    Dex.DEf = fields[7];
                    Dex.SpAtk = fields[8];
                    Dex.SpDef = fields[9];
                    Dex.Spd = fields[10];
                    Dex.Generation = fields[11];
                    Dex.Legendary = fields[12];
                    Pokedex.Add(Dex);

                }
            }
            using (TextFieldParser parser = FileSystem.OpenTextFieldParser("Galar.csv", delimiters))
            {

                while (!parser.EndOfData)
                {


                    string[] fields = parser.ReadFields();
                    Galar.Add(fields[0]); ;
                }
            }



        }


        private void btnEnter_Click(object sender, EventArgs e)
        {
            btnAll.Enabled = true;
            lstpokemon.Items.Clear();
            String search = "TRUE";

            foreach (var Item in Pokedex)
            {
                if (clicked == false)
                {
                    if (search == Item.Legendary)
                    {
                        ListViewItem item1 = new ListViewItem(Item.DexNumber);
                        item1.SubItems.Add(Item.Name);
                        item1.SubItems.Add(Item.Type1);
                        item1.SubItems.Add(Item.Type2);
                        item1.SubItems.Add(Item.Total);
                        item1.SubItems.Add(Item.HP);
                        item1.SubItems.Add(Item.ATK);
                        item1.SubItems.Add(Item.DEf);
                        item1.SubItems.Add(Item.SpAtk);
                        item1.SubItems.Add(Item.SpDef);
                        item1.SubItems.Add(Item.Spd);
                        item1.SubItems.Add(Item.Generation);
                        item1.SubItems.Add(Item.Legendary);
                        lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                    }
                }
                else
                {
                    if (search == Item.Legendary && input == Item.Generation)
                    {
                        ListViewItem item1 = new ListViewItem(Item.DexNumber);
                        item1.SubItems.Add(Item.Name);
                        item1.SubItems.Add(Item.Type1);
                        item1.SubItems.Add(Item.Type2);
                        item1.SubItems.Add(Item.Total);
                        item1.SubItems.Add(Item.HP);
                        item1.SubItems.Add(Item.ATK);
                        item1.SubItems.Add(Item.DEf);
                        item1.SubItems.Add(Item.SpAtk);
                        item1.SubItems.Add(Item.SpDef);
                        item1.SubItems.Add(Item.Spd);
                        item1.SubItems.Add(Item.Generation);
                        item1.SubItems.Add(Item.Legendary);
                        lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                    }
                }
            }

        }



        private void btnName_Click(object sender, EventArgs e)
        {
            btnAll.Enabled = true;
            clicked = false;
            lstpokemon.Items.Clear();
            string input = Microsoft.VisualBasic.Interaction.InputBox("Enter Name", "Pokemon");
            foreach (var Item in Pokedex)
            {
                if (input.ToLower() == Item.Name.ToLower())
                {
                    ListViewItem item1 = new ListViewItem(Item.DexNumber);
                    item1.SubItems.Add(Item.Name);
                    item1.SubItems.Add(Item.Type1);
                    item1.SubItems.Add(Item.Type2);
                    item1.SubItems.Add(Item.Total);
                    item1.SubItems.Add(Item.HP);
                    item1.SubItems.Add(Item.ATK);
                    item1.SubItems.Add(Item.DEf);
                    item1.SubItems.Add(Item.SpAtk);
                    item1.SubItems.Add(Item.SpDef);
                    item1.SubItems.Add(Item.Spd);
                    item1.SubItems.Add(Item.Generation);
                    item1.SubItems.Add(Item.Legendary);
                    lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                }
            }
        }

        private void btnAll_Click(object sender, EventArgs e)
        {
            btnAll.Enabled = false;
            clicked = false;
            lstpokemon.Items.Clear();
            foreach (var Item in Pokedex)
            {
                ListViewItem item1 = new ListViewItem(Item.DexNumber);
                item1.SubItems.Add(Item.Name);
                item1.SubItems.Add(Item.Type1);
                item1.SubItems.Add(Item.Type2);
                item1.SubItems.Add(Item.Total);
                item1.SubItems.Add(Item.HP);
                item1.SubItems.Add(Item.ATK);
                item1.SubItems.Add(Item.DEf);
                item1.SubItems.Add(Item.SpAtk);
                item1.SubItems.Add(Item.SpDef);
                item1.SubItems.Add(Item.Spd);
                item1.SubItems.Add(Item.Generation);
                item1.SubItems.Add(Item.Legendary);
                lstpokemon.Items.AddRange(new ListViewItem[] { item1 });

            }
        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            btnAll.Enabled = true;
            clicked = true;
            lstpokemon.Items.Clear();
            input = Microsoft.VisualBasic.Interaction.InputBox("Enter Gen number", "from 1-6");
            foreach (var Item in Pokedex)
            {
                if (input == Item.Generation)
                {
                    ListViewItem item1 = new ListViewItem(Item.DexNumber);
                    item1.SubItems.Add(Item.Name);
                    item1.SubItems.Add(Item.Type1);
                    item1.SubItems.Add(Item.Type2);
                    item1.SubItems.Add(Item.Total);
                    item1.SubItems.Add(Item.HP);
                    item1.SubItems.Add(Item.ATK);
                    item1.SubItems.Add(Item.DEf);
                    item1.SubItems.Add(Item.SpAtk);
                    item1.SubItems.Add(Item.SpDef);
                    item1.SubItems.Add(Item.Spd);
                    item1.SubItems.Add(Item.Generation);
                    item1.SubItems.Add(Item.Legendary);
                    lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                }
            }

        }

        private void cmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstpokemon.Items.Clear();
            foreach (var Item in Pokedex)
            {
                if (clicked == false)
                {
                    if (cmbType.SelectedItem.ToString().ToLower() == Item.Type1.ToLower() || cmbType.SelectedItem.ToString().ToLower() == Item.Type2.ToLower())
                    {
                        ListViewItem item1 = new ListViewItem(Item.DexNumber);
                        item1.SubItems.Add(Item.Name);
                        item1.SubItems.Add(Item.Type1);
                        item1.SubItems.Add(Item.Type2);
                        item1.SubItems.Add(Item.Total);
                        item1.SubItems.Add(Item.HP);
                        item1.SubItems.Add(Item.ATK);
                        item1.SubItems.Add(Item.DEf);
                        item1.SubItems.Add(Item.SpAtk);
                        item1.SubItems.Add(Item.SpDef);
                        item1.SubItems.Add(Item.Spd);
                        item1.SubItems.Add(Item.Generation);
                        item1.SubItems.Add(Item.Legendary);
                        lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                    }
                }
                else
                {
                    if (cmbType.SelectedItem.ToString().ToLower() == Item.Type1.ToLower() && input == Item.Generation || cmbType.SelectedItem.ToString().ToLower() == Item.Type2.ToLower() && input == Item.Generation)
                    {
                        ListViewItem item1 = new ListViewItem(Item.DexNumber);
                        item1.SubItems.Add(Item.Name);
                        item1.SubItems.Add(Item.Type1);
                        item1.SubItems.Add(Item.Type2);
                        item1.SubItems.Add(Item.Total);
                        item1.SubItems.Add(Item.HP);
                        item1.SubItems.Add(Item.ATK);
                        item1.SubItems.Add(Item.DEf);
                        item1.SubItems.Add(Item.SpAtk);
                        item1.SubItems.Add(Item.SpDef);
                        item1.SubItems.Add(Item.Spd);
                        item1.SubItems.Add(Item.Generation);
                        item1.SubItems.Add(Item.Legendary);
                        lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            lstpokemon.Items.Clear();
            foreach (var Item in Pokedex)
            {

                if (stats.Stat == "Atk" && stats.Num <= Convert.ToInt16(Item.ATK) || stats.Stat == "Def" && stats.Num <= Convert.ToInt16(Item.DEf) || stats.Stat == "SpAtk" && stats.Num <= Convert.ToInt16(Item.SpAtk) ||
                stats.Stat == "SpDef" && stats.Num <= Convert.ToInt16(Item.SpDef) || stats.Stat == "Spd" && stats.Num <= Convert.ToInt16(Item.Spd) || stats.Stat == "HP" && stats.Num <= Convert.ToInt16(Item.HP) || stats.Stat == "Total" && stats.Num <= Convert.ToInt16(Item.Total))
                {
                    ListViewItem item1 = new ListViewItem(Item.DexNumber);
                    item1.SubItems.Add(Item.Name);
                    item1.SubItems.Add(Item.Type1);
                    item1.SubItems.Add(Item.Type2);
                    item1.SubItems.Add(Item.Total);
                    item1.SubItems.Add(Item.HP);
                    item1.SubItems.Add(Item.ATK);
                    item1.SubItems.Add(Item.DEf);
                    item1.SubItems.Add(Item.SpAtk);
                    item1.SubItems.Add(Item.SpDef);
                    item1.SubItems.Add(Item.Spd);
                    item1.SubItems.Add(Item.Generation);
                    item1.SubItems.Add(Item.Legendary);
                    lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                }
            }
            btnEnter.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lstpokemon.Items.Clear();
            btnEnter.Enabled = true;
            stats.ShowDialog();
            foreach (var Item in Pokedex)
            {
                foreach (var poke in Galar)
                {
                    if (clicked == true)
                    {
                        if (poke == Item.Name && stats.Stat == "Atk" && stats.Num <= Convert.ToInt16(Item.ATK) || poke == Item.Name && stats.Stat == "Def" && stats.Num <= Convert.ToInt16(Item.DEf) || poke == Item.Name && stats.Stat == "SpAtk" && stats.Num <= Convert.ToInt16(Item.SpAtk) ||
                              poke == Item.Name && stats.Stat == "SpDef" && stats.Num <= Convert.ToInt16(Item.SpDef) || poke == Item.Name && stats.Stat == "Spd" && stats.Num <= Convert.ToInt16(Item.Spd) || poke == Item.Name && stats.Stat == "HP" && stats.Num <= Convert.ToInt16(Item.HP) ||
                              poke == Item.Name && stats.Stat == "Total" && stats.Num <= Convert.ToInt16(Item.Total))
                        {
                            ListViewItem item1 = new ListViewItem(Item.DexNumber);
                            item1.SubItems.Add(Item.Name);
                            item1.SubItems.Add(Item.Type1);
                            item1.SubItems.Add(Item.Type2);
                            item1.SubItems.Add(Item.Total);
                            item1.SubItems.Add(Item.HP);
                            item1.SubItems.Add(Item.ATK);
                            item1.SubItems.Add(Item.DEf);
                            item1.SubItems.Add(Item.SpAtk);
                            item1.SubItems.Add(Item.SpDef);
                            item1.SubItems.Add(Item.Spd);
                            item1.SubItems.Add(Item.Generation);
                            item1.SubItems.Add(Item.Legendary);
                            lstpokemon.Items.AddRange(new ListViewItem[] { item1 });


                        }
                    }
                }
            }

        }

        private void lstpokemon_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGalar_Click(object sender, EventArgs e)
        {
            clicked = true;
            lstpokemon.Items.Clear();
            foreach (var Item in Pokedex)
            {
                foreach (var poke in Galar)
                {

                    if (poke == Item.Name)
                    {

                        ListViewItem item1 = new ListViewItem(Item.DexNumber);
                        item1.SubItems.Add(Item.Name);
                        item1.SubItems.Add(Item.Type1);
                        item1.SubItems.Add(Item.Type2);
                        item1.SubItems.Add(Item.Total);
                        item1.SubItems.Add(Item.HP);
                        item1.SubItems.Add(Item.ATK);
                        item1.SubItems.Add(Item.DEf);
                        item1.SubItems.Add(Item.SpAtk);
                        item1.SubItems.Add(Item.SpDef);
                        item1.SubItems.Add(Item.Spd);
                        item1.SubItems.Add(Item.Generation);
                        item1.SubItems.Add(Item.Legendary);
                        lstpokemon.Items.AddRange(new ListViewItem[] { item1 });
                    }

                }
            }


        }
    }
}














