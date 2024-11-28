using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*A feladat hogy szimuláljuk ahogy az elektronok végigmennek a vezetéken. Az elektron az akkumulátor negatív feléről indul a pozitív felé. Az áramkörben van egy feszültésg szabályzó és
 * egy fogyasztó. A feszültség szabályzóig konstans sebességgel haladnak az elektronok. A feszültség szabályzó az utána lévő részre beállítja az elektron sebességét.
Az akkumulátor 24 Voltos.
Az alapértelmezett feszültség érték 12 Volt amit egyesével lehet fel és le módosítani.
A maximális feszültség nem lehet nagyobb az akku feszültségénél. 
Miután egy elektron áthaladt a feszültség szabályzón, a sebessége változatlan marad.
A sebességet arányosan kell beállítani. Ha 12 Volton megy az elektron, akkor a 24 Voltos sebesség 50 százalékával kell haladnia.
A mozgás timer intervallumja fixen 16ms.
Van egy számláló ami visszajelzést nyújt arról hány elektron jutott vissza az akkuba.
Az elektronok fél másodpercenként jönnek létre */


namespace Elekton_Project
{
    public partial class Form1 : Form
    {
        Timer electronTimer = new Timer();
        
        int voltSize = 12;
        int xDirection = 0;
        int yDirection = -1;
        int electronCount = 368;
     
        int upVoltage = 24;
        int downVoltage = 1;

        public Form1()
        {
            InitializeComponent();
            this.Text = "Feszültség";
            Start();

        }
        void Start() 
        {
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        void startTimer() 
        {
            electronTimer.Interval = 24;
            feszultsegEvent();
            moveEvent();
            electronTimer.Start();
            //electronTimer.Tick += electronSpeed;
        }
        void feszultsegEvent()
          
        {
            electronTimer.Interval = 24;
            
            electronTimer.Start();

        }
        void moveEvent() 
        {
           // upVoltage.Click += upVolt;
            //downVoltage.Click += downVoltage;
        }
       
        void switchEvent(object s, EventArgs e) 
        { 
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (voltSize < 24)
            {
                voltSize++;
                label2.Text = voltSize.ToString() + "V";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (voltSize > 1)
            {
                voltSize--;
                label2.Text = voltSize.ToString() + "V";
            }
        }
    }
}
