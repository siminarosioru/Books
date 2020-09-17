using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Books
{
    public partial class FormProjectBooks : Form
    {
        //constructor
        public FormProjectBooks()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                //declaring a variable + initialization
                string book = textInput.Text;

                //add books
                listBooks.Items.Add(book);

                //can view how many books are in the list
                textOutput.Text = listBooks.Items.Count.ToString();
            }
            catch
            {
                MessageBox.Show("Error");
            }
        }
        private void listBooks_SelectedIndexChanged(object sender, EventArgs e)
        {
            textOutput.Text = listBooks.SelectedIndex.ToString();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            string book = textInput.Text;

            //for loop
            for(int i = 0; i < listBooks.Items.Count; i++)
            {
                //check if the inserted book is in the list
                if (listBooks.Items[i].Equals(book))
                    MessageBox.Show("Book: " + book + " is in the list", "Output");
                else
                    MessageBox.Show("the book isn't in the list");
            }
        }

        private void buttonShow_Click(object sender, EventArgs e)
        {
            //create the class object using the default constructor
            BookClass objectBook = new BookClass();

            objectBook.BOOK = "Uneori CASTIGI, uneori INVETI, John C. Maxwell" + Environment.NewLine
                + "Inteligenta emotionala, Daniel Goleman" + Environment.NewLine
                + "Puterea nemarginita, Anthony Robbins" + Environment.NewLine
                + "Intuitia, Gerd Gigerenzer" + Environment.NewLine
                + "Secretele intregii vieti, Elena Iulianu Neagu & John Yorgos" + Environment.NewLine
                + "De la IDEE la BANI, Napoleon Hill" + Environment.NewLine
                + "Arta subtila a nepasarii, Mark Manson" + Environment.NewLine
                + "Daca m-as asculta, m-as intelege, Jacques Salome" + Environment.NewLine
                + "Cele 15 legi supreme ale dezvoltarii personale, John C. Maxwell" + Environment.NewLine
                + "12 reguli de viata - Un antidot la haosul din jurul nostru, Jordan Peterson" + Environment.NewLine
                + "Arta posibilului, Rosamund Stone Zander & Benjamin Zander" + Environment.NewLine
                + "Ce ar fi daca ne-am inventa propria viata?, Jacques Salome" + Environment.NewLine
                + "Totul despre LIDERI, ATITUDINE, ECHIPA,  RELATII, John C. Maxwell" + Environment.NewLine
                + "Cele 21 de legi supreme ale LIDERULUI, John C. Maxwell" + Environment.NewLine
                + "Mintea Opozabila, Roger Martin" + Environment.NewLine
                + "A avea sau a fi? Erich Fromm" + Environment.NewLine
                +"Manual de NLP, Joseph O'Connor" + Environment.NewLine
                + "Atitudinea este totul, Keller" + Environment.NewLine
                + "Distruge-ti obiceiurile nocive!, Joe Dispenza" + Environment.NewLine;

            objectBook.NEWBook = Convert.ToString(textInput.Text);

            foreach(var book in listBooks.Items)
            {
                objectBook.NEWBook += book + Environment.NewLine;
            }

            MessageBox.Show(objectBook.BOOK + objectBook.NEWBook);
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            //remove a selected book from list
            listBooks.Items.RemoveAt(listBooks.SelectedIndex);
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            //delete all the books you have added
            listBooks.Items.Clear();
        }
    }
}
