using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.Data;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Ark_Codes_Xbox
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("r.VolumetricCloud 0 |  r.VolumetricFog 0 | grass.sizeScale 0.3");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
        DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat gmsummon 'Ptero_Character_BP_C' 300 | cheat gfi PteroSaddle 1 100 0 | cheat GFI Seed_Test 10000 0 0 | Cheat GFI Armor_MetalPants 01 100 0 | Cheat GFI Armor_MetalShirt 01 100 0 | Cheat GFI Armor_MetalHelmet 01 100 0 | Cheat GFI Armor_MetalBoots 01 100 0 | Cheat GFI Armor_MetalGloves 01 100 0 | Cheat GFI WeaponMetalPick 01 100 0 | Cheat GFI WeaponPike 01 100 0 | Cheat GFI WeaponMetalHatchet 01 100 0 | Cheat GFI WeaponCrossbow 01 100 0 | Cheat GFI WeaponTorch 01 100 0 | cheat giveitem '/SuperSpyglassPlus/Spyglass/PrimalItem_SSP_Consumable.PrimalItem_SSP_Consumable' 1 0 0 false | Cheat GFI Consumable_CanteenRefill 01 100 0");
            Clipboard.SetContent(dataPackage);
        }
    }
}
