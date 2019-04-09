using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App6.Modelos;

namespace App6
{
    public partial class MainPage : ContentPage
    {
        // vetor de professores
        Professor[] professores = new Professor[4]
        {
            new Professor("Maria", 1),
            new Professor("José", 2),
            new Professor("João", 3),
            new Professor("Ana", 4)
        };

        // vetor de disciplinas
        Disciplina[] disciplinas = new Disciplina[4]
        {
            new Disciplina("Cálculo 1", 1),
            new Disciplina("Introdução a Engenharia", 2),
            new Disciplina("Cálculo 2", 3),
            new Disciplina("Projetos de Engenharia", 4)
        };

        public MainPage()
        {
            InitializeComponent();

            //para todos as disciplinas do vetor
            foreach (Disciplina disciplina in disciplinas)
            {
                // adicionar um elemento na caixa de seleção
                Picker1.Items.Add(disciplina.semestre + " - " + disciplina.nome);
            }

            foreach (Professor professor in professores)
            {
                // adicionar um elemento na caixa de seleção
                Picker2.Items.Add(professor.semestre + " - " + professor.nome);
            }
        }

        void OnButtonClicked(object sender, EventArgs args)
        {
            // desabilitar mensagens
            Label1.IsVisible = false;
            Label2.IsVisible = false;
            Label3.IsVisible = false;

            // verificar se a nota foi selecionados
            if (Entry2.Text != null &&
                Entry2.Text.Length > 0 &&
                Picker1.SelectedIndex >= 0 && Picker2.SelectedIndex >= 0)
            {
                Label1.IsVisible = true;

                int nota;

                nota = int.Parse(Entry2.Text);

                if (nota >= 6 )
                {
                   
                    Label2.IsVisible = true;
                }
                else
                {
                    Label3.IsVisible = true;
                }
            }

        }

    }
}

