using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TareaDos
{
    public partial class Form1 : Form
    {
        string[] principal = new string[100];
        int[] numeros = new int[60];
        string[] letras = new string[60];
        int i = 0;
        public delegate void ActualizaPrincipal();
        public delegate void ActualizaNumeros();
        public delegate void ActualizaLetras();
        private Object principalLock = new object();
        private Object numeroslock = new object();
        private Object letraslock = new object();
        private Thread hiloPrincipal = null;
        private Thread hiloNumeros = null;
        private Thread hiloLetras = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void procesarPrincipal()
        {
            while (true)
            {
               dGVPrincipal.Invoke(new ActualizaPrincipal(this.agregarFilaPrincipal));
                Thread.Sleep(500);
            }
        }

        private void procesarNumeros()
        {
            while (true)
            {
                dGVNumeros.Invoke(new ActualizaNumeros(this.agregarFilaNumeros));
                Thread.Sleep(500);
            }
        }

        private void procesarLetras()
        {
            while (true)
            {
                dGVLetras.Invoke(new ActualizaLetras(this.agregarFilaLetras));
                Thread.Sleep(500);
            }
        }


        private void agregarFilaPrincipal()
        {
            dGVPrincipal.Rows.Clear();
            lock (principalLock)
            {
                foreach (string entrada in principal)
                {
                    if (entrada != null)
                    {
                        dGVPrincipal.Rows[dGVPrincipal.Rows.Add()].Cells[0].Value = entrada;
                    }
                }
            }
        }

        private void agregarFilaNumeros()
        {
            dGVNumeros.Rows.Clear();
            lock (numeroslock)
            {
                int valor = 0;
                int j = 0;
                int k = 0;
                Array.Clear(numeros, 0, numeros.Length);
                for (j = 0; j < principal.Length; j++)
                {
                    if (int.TryParse(principal[j], out valor) && (k < numeros.Length))
                    {
                        numeros[k] = valor;
                        k++;
                    }
                }
                Array.Sort(numeros);
                foreach (int numero in numeros)
                {
                    if (numero != 0)
                    {
                        dGVNumeros.Rows[dGVNumeros.Rows.Add()].Cells[0].Value = numero;
                    }
                }
            }
        }

        private void agregarFilaLetras()
        {
           dGVLetras.Rows.Clear();
            lock (letraslock)
            {
                int valor;
                int j = 0;
                int l = 0;
                Array.Clear(letras, 0, letras.Length);
                for (j = 0; j < principal.Length; j++)
                {
                    if (!int.TryParse(principal[j], out valor) && (l < letras.Length))
                    {
                        if (l < letras.Length)
                        {
                            letras[l] = principal[j];
                            l++;
                        }
                    }
                }
                foreach (string letra in letras)
                {
                    if (letra != null)
                    {
                        dGVLetras.Rows[dGVLetras.Rows.Add()].Cells[0].Value = letra;
                    }
                }
            }
        }
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            if ((i < 100) && (cajaTexto.Text !=""))
            {
                lock(principalLock)
                    {
                        principal[i++] = cajaTexto.Text;
                    }
            }
            else
            {
                MessageBox.Show("¡Se alcanzó el tamaño máximo del Arreglo!");
            }
            cajaTexto.Text = "";
            cajaTexto.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            dGVPrincipal.Refresh();
            dGVLetras.Refresh();
            dGVNumeros.Refresh();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            hiloPrincipal = new Thread(new ThreadStart(this.procesarPrincipal));
            hiloNumeros = new Thread(new ThreadStart(this.procesarNumeros));
            hiloLetras = new Thread(new ThreadStart(this.procesarLetras));
            hiloPrincipal.Start();
            hiloNumeros.Start();
            hiloLetras.Start();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            hiloPrincipal.Abort();
            hiloNumeros.Abort();
            hiloLetras.Abort();
        }
    }
}
