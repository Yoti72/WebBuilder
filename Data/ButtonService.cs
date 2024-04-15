using System.Threading.Tasks;

namespace WebBuilder.Data
{
    public class ButtonService
    {
        public string? ButtonText { get; private set; }
        public string? ButtonColor { get; private set; }
        public string? ButtonHeight { get; private set; }
        public string? ButtonWidth { get; private set; }
        public string? ButtonFont { get; private set; }
        public string? ButtonFontWeight { get; private set; }
        public string? ButtonFontSize { get; private set; }
        public string? ButtonTextColor { get; private set; }
        public string? ButtonCornerRadius { get; private set; } 
        public string? NumberOfButtons { get; private set; }

        public void SetButtonProperties(string buttonText, string buttonColor, string buttonHeight, string buttonWidth, string buttonFont, string buttonFontWeight, string buttonFontSize, string buttonTextColor, string buttonCornerRadius, string numberOfButtons)
        {
            ButtonText = buttonText;
            ButtonColor = buttonColor;
            ButtonHeight = buttonHeight;
            ButtonWidth = buttonWidth;
            ButtonFont = buttonFont;
            ButtonFontWeight =  buttonFontWeight;
            ButtonFontSize = buttonFontSize;
            ButtonTextColor = buttonTextColor;
            ButtonCornerRadius = buttonCornerRadius;
            NumberOfButtons = numberOfButtons;
        }
  
    }
}