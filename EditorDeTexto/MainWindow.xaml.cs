using System.IO;
using System.Windows;
using System.Windows.Input;
using Microsoft.Win32;

namespace EditorDeTexto;

public partial class MainWindow : Window
{
    // Guarda la ruta del archivo abierto (null si aún no tiene archivo)
    private string? _ruta;

    public MainWindow()
    {
        InitializeComponent();
    }

    // ---------- ABRIR ----------
    private void Abrir_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        var dialogo = new OpenFileDialog // crea un diálogo de abrir archivo
        {
            Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*" // filtro de tipos de archivo
        };

        if (dialogo.ShowDialog() != true) return; // el usuario canceló

        try
        {
            txtEditor.Text = File.ReadAllText(dialogo.FileName); // lo lee y lo pone en el editor
            _ruta = dialogo.FileName; // guarda la ruta del archivo abierto
            Title = Path.GetFileName(_ruta); // cambia el título de la ventana al nombre del archivo
        }
        catch (FileNotFoundException)
        {
            MessageBox.Show("El archivo no existe.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show("No tienes permisos para leer este archivo.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (IOException ex)
        {
            MessageBox.Show("No se pudo leer el archivo (¿está abierto en otro programa?):\n" + ex.Message,
                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error inesperado:\n" + ex.Message, "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // ---------- GUARDAR ----------
    private void Guardar_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        // Validación: no guardar un documento vacío
        if (string.IsNullOrWhiteSpace(txtEditor.Text))
        {
            MessageBox.Show("No hay nada que guardar. Escribe algún texto primero.", "Aviso",
                MessageBoxButton.OK, MessageBoxImage.Warning);
            return;
        }

        // Tiene archivo? Si no, preguntar dónde
        if (_ruta == null)
        {
            var dialogo = new SaveFileDialog
            {
                Filter = "Archivos de texto (*.txt)|*.txt",
                DefaultExt = ".txt"
            };

            if (dialogo.ShowDialog() != true) return; // el usuario canceló
            _ruta = dialogo.FileName;
        }
        // Guardar el archivo, escribe
        try
        {
            File.WriteAllText(_ruta, txtEditor.Text); //la ruta y el contenido del editor
            Title = Path.GetFileName(_ruta);
            MessageBox.Show("Archivo guardado correctamente.", "Guardar",
                MessageBoxButton.OK, MessageBoxImage.Information);
        }
        catch (UnauthorizedAccessException)
        {
            MessageBox.Show("No tienes permisos para escribir en esa ubicación.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            _ruta = null;
        }
        catch (DirectoryNotFoundException)
        {
            MessageBox.Show("La carpeta de destino no existe.", "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
            _ruta = null;
        }
        catch (IOException ex)
        {
            MessageBox.Show("No se pudo guardar (¿disco lleno o archivo en uso?):\n" + ex.Message,
                "Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error inesperado:\n" + ex.Message, "Error",
                MessageBoxButton.OK, MessageBoxImage.Error);
        }
    }

    // ---------- AYUDA / ACERCA DE ----------
    private void Ayuda_Executed(object sender, ExecutedRoutedEventArgs e)
    {
        MessageBox.Show(
            "Atajos:\n" +
            "Ctrl+O  Abrir\n" +
            "Ctrl+S  Guardar\n" +
            "Ctrl+C  Copiar\n" +
            "Ctrl+V  Pegar\n" +
            "Ctrl+Z  Deshacer\n" +
            "Ctrl+Y  Rehacer\n" +
            "F1      Esta ayuda",
            "Acerca de", MessageBoxButton.OK, MessageBoxImage.Information);
    }
}