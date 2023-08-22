using Microsoft.VisualBasic.Devices;

namespace ParcialTema1Windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int largo;
        int altura;
        int ancho;
        double area;
        double volumen;
        double basee;
        double areaAltura;
        double areaAncho;
        double diagonal;
        int contador;
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidarNumeros() == false)
            {
                MessageBox.Show("Error ingrese numero");
            }
            else
            {
                if (largo < 0 || altura < 0 || ancho < 0)
                {
                    MessageBox.Show("Error ingrese numero positivo");
                }
                else if (largo == 0 || altura == 0 || ancho == 0)
                {
                    MessageBox.Show("Los Valores no pueden ser 0");
                }
                else
                {
                    areaAltura = ancho * altura;
                    basee = largo * ancho;
                    areaAncho = largo * altura;
                    area = 2 * (basee + areaAltura + areaAncho);
                    volumen = largo * altura * ancho;
                    diagonal = Math.Sqrt((Math.Pow(altura, 2)) + (Math.Pow(largo, 2)) + (Math.Pow(ancho, 2)));
                    MessageBox.Show($"El area es {area}, el volumen es {volumen} y la diagonal es {diagonal}");
                    LargoText.Clear();
                    AlturaText.Clear();
                    AnchoText.Clear();
                    contador = contador + 1;
                    contadorLable.Text = contador.ToString();
                }


            }
        }

        private bool ValidarNumeros()
        {
            bool validar = true;

            if (!int.TryParse(LargoText.Text, out largo))
            {
                validar = false;

            }
            if (!int.TryParse(AlturaText.Text, out altura))
            {
                validar = false;
            }
            if (!int.TryParse(AnchoText.Text, out ancho))
            {
                validar = false;
            }
            return validar;
        }
    