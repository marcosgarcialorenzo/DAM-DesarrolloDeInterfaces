using GestorDeTareasGrafico.Controllers;

namespace GestorDeTareasGrafico;

public partial class Form1 : Form
{
    private readonly TaskItemController controller;

    public Form1(TaskItemController controller)
    {
        InitializeComponent();
        this.controller = controller;
    }
}