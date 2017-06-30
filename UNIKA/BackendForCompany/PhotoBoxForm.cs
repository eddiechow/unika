using MetroFramework.Forms;
using System.Drawing;

namespace BackendForCompany
{
    public partial class PhotoBoxForm : MetroForm
    {
        public PhotoBoxForm(Image photo)
        {
            InitializeComponent();

            photoBox.Image = photo;
        }
    }
}
