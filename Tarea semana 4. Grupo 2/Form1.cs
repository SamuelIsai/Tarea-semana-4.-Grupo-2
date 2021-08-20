using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_semana_4.Grupo_2
{
    public partial class Form1 : Form
    {
        // Crea un objeto aleatorio llamado aleatorizador
        // para generar numeros aleatorios.
        Random randomizer = new Random();

        // Estas variables enteras almacenan los números
        // para el problema de la suma.
        int addend1;
        int addend2;

        /// <resumen>
        /// Inicie el cuestionario completando todos los problemas
        /// e iniciando el temporizador.
        /// </summary>
        public void StartTheQuiz()
        {

            // Completa el problema de la suma.
            // Genera dos números aleatorios para sumar.
            // Almacenar los valores en las variables 'addend1' y 'addend2'.
            addend1 = randomizer.Next(51);
            addend2 = randomizer.Next(51);

            // Convierte los dos números generados aleatoriamente
            // en cadenas para que se puedan mostrar
            // en los controles de la etiqueta.
            plusLeftLabel.Text = addend1.ToString();
            plusRightLabel.Text = addend2.ToString();


            // 'suma' es el nombre del control NumericUpDown.
            // Este paso asegura que su valor sea cero antes
            // añadiéndole cualquier valor.
            suma.Value = 0;
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            StartTheQuiz();
            startButton.Enabled = false;
        }
    }
}
