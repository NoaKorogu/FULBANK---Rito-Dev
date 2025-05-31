using Xunit;
using Moq;
using System.Windows.Forms;
using Fulbank.View;
using Fulbank.ViewModel.Conversion;
using System.Reflection.Emit;

public class ConvChooseCodeTests
{
    private Mock<IConvChoose> _mockForm;
    private ConvChooseCode _convChooseCode;
    private System.Windows.Forms.Label _mockLabel;

    public ConvChooseCodeTests()
    {
        // Création d'un mock de ConvChoose
        _mockForm = new Mock<IConvChoose>();

        // Création d'un label simulé
        _mockLabel = new System.Windows.Forms.Label();
        _mockLabel.Text = "10"; // Valeur initiale pour les tests

        // Simulation du label dans le mock de ConvChoose
        _mockForm.Setup(f => f.Lbl_AmountControl).Returns(_mockLabel);

        // Création de l'instance de ConvChooseCode avec le mock
        _convChooseCode = new ConvChooseCode(_mockForm.Object);
    }

    [Fact]
    public void AddAmount_ShouldIncreaseAmount()
    {
        // Act
        _convChooseCode.AddAmount(5);

        // Assert
        Assert.Equal("15", _mockLabel.Text);
    }

    [Fact]
    public void SupAmount_ShouldDecreaseAmount()
    {
        // Act
        _convChooseCode.SupAmount(5);

        // Assert
        Assert.Equal("5", _mockLabel.Text);
    }

    [Fact]
    public void SupAmount_ShouldNotGoBelowZero()
    {
        // Act
        _convChooseCode.SupAmount(15);

        // Assert
        Assert.Equal("0,0", _mockLabel.Text);
    }

    [Fact]
    public void AddAmountFromTextBox_ShouldIncreaseAmount_WhenValidNumber()
    {
        // Act
        _convChooseCode.AddAmountFromTextBox("5");

        // Assert
        Assert.Equal("15", _mockLabel.Text);
    }

    [Fact]
    public void AddAmountFromTextBox_ShouldNotChangeAmount_WhenInvalidNumber()
    {
        // Act
        _convChooseCode.AddAmountFromTextBox("invalid");

        // Assert
        Assert.Equal("10", _mockLabel.Text); // L'ancien montant doit rester inchangé
    }

    [Fact]
    public void SupAmountFromTextBox_ShouldDecreaseAmount_WhenValidNumber()
    {
        // Act
        _convChooseCode.SupAmountFromTextBox("5");

        // Assert
        Assert.Equal("5", _mockLabel.Text);
    }

    [Fact]
    public void SupAmountFromTextBox_ShouldNotChangeAmount_WhenInvalidNumber()
    {
        // Act
        _convChooseCode.SupAmountFromTextBox("invalid");

        // Assert
        Assert.Equal("10", _mockLabel.Text); // L'ancien montant doit rester inchangé
    }
}
