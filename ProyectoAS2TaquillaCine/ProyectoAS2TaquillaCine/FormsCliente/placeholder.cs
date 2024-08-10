using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoAS2TaquillaCine.FormsCliente
{
    public class PlaceholderManager
    {
        private string _placeholderText;
        private Color _placeholderColor;
        private Color _textColor;
        private Control _control;

        public PlaceholderManager(Control control, string placeholderText, Color placeholderColor, Color textColor)
        {
            _control = control;
            _placeholderText = placeholderText;
            _placeholderColor = placeholderColor;
            _textColor = textColor;

            InitializePlaceholder();
        }

        private void InitializePlaceholder()
        {
            // Establece el texto del placeholder
            _control.Text = _placeholderText;
            _control.ForeColor = _placeholderColor;

            // Asigna eventos para manejar el placeholder
            _control.GotFocus += RemovePlaceholder;
            _control.LostFocus += SetPlaceholder;
        }

        private void RemovePlaceholder(object sender, EventArgs e)
        {
            if (_control.Text == _placeholderText)
            {
                _control.Text = "";
                _control.ForeColor = _textColor;
            }
        }

        private void SetPlaceholder(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(_control.Text))
            {
                _control.Text = _placeholderText;
                _control.ForeColor = _placeholderColor;
            }
        }
    }
}
