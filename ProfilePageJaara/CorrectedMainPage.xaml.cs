using ProfilePageJaara.Models;

namespace ProfilePageJaara;

public partial class CorrectedMainPage : ContentPage
{
	public CorrectedMainPage()
	{
		InitializeComponent();
        BindingContext = new CorrectedCodeBehind();
	}

    private List<CorrectedCodeBehind> GetCorrectedCodeBehinds()
	{
		return new List<CorrectedCodeBehind>
		{
            new CorrectedCodeBehind {RowName="View Profile",Image="profilep.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Notifications",Image="notificationsp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Change Pin",Image="pinp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="ID Verification",Image="verifiedp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Terms & Conditions",Image="filep.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Privacy Policy",Image="warningp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="FAQs",Image="messagep.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Contact Us",Image="contactp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Logout",Image="logoutp.svg", ImButton="chevron.svg"},
            new CorrectedCodeBehind {RowName="Delete Account",Image="deleter.svg", ImButton="chevron.svg"}
        };
	}
}