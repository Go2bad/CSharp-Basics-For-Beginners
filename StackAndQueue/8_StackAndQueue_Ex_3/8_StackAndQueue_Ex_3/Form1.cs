using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_StackAndQueue_Ex_3
{
    public partial class Form1 : Form
    {
        Queue<int> breakfastLine = new Queue<int>();
        Queue<string> names = new Queue<string>();
        
        Flapjack food;
        int number = 0;
        int amountOfFlapjack = 0;

        public Form1()
        {
            InitializeComponent();
        }
     
        private void addLumberjack_Click(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;

            names.Enqueue(name.Text);
            breakfastLine.Enqueue(number++);
            line.Items.Add(number + ". " + name.Text);

            result.Text = names.Peek() + " has 0 flapjacks.";

            name.Text = "";
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (crispyButton.Checked)
            {
                food = Flapjack.Crispy;
            }
            else if (soggyButton.Checked)
            {
                food = Flapjack.Soggy;
            }
            else if (brownedButton.Checked)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }
            
            amountOfFlapjack += (int)howMany.Value;
            result.Text = names.Peek() + " has " + amountOfFlapjack + " flapjacks.";
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Console.WriteLine(names.Peek() + " is eating flapjacks");

            for (int i = 0; i < amountOfFlapjack; i++)
            {
                Console.WriteLine(names.Peek() + " ate a " + food + " flapjack;");
            }

            result.Text = names.Peek() + " has " + amountOfFlapjack + " flapjacks.";

            names.Dequeue();
            amountOfFlapjack = 0;
            RedrawList();

            if (names.Count == 0)
            {
                groupBox1.Enabled = false;
                number = 0;
            }

            

            // Output:

            /*
            Andrew’s eating flapjacks
            Andrew ate a banana flapjack
            Andrew ate a banana flapjack
            Andrew ate a banana flapjack
            Andrew ate a browned flapjack
            Andrew ate a crispy flapjack
            */

        }

        private void RedrawList()
        {
            int newNumber = 1;
            line.Items.Clear();
            foreach (string name in names)
            {
                line.Items.Add(newNumber++ + ". " + name);
            }
        }
    }
}
