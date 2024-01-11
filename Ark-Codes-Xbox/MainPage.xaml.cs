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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0 | cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0| cheat GFI Kibble_Base_Special 100 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI RefinedTranq 100 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0 | cheat GFI JellyVenom 100 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI Extinction_DesertKaiju 1 0 0 | cheat GFI Extinction_ForestKaiju 1 0 0 | cheat GFI Artifact_12 1 0 0 | cheat GFI Artifact_05 1 0 0 | cheat GFI ArtifactSE_02 1 0 0 | cheat GFI Artifact_11 1 0 0 | cheat GFI ArtifactAB 1 0 0 | cheat GFI ArtifactSE_03 1 0 0 | cheat GFI Artifact_04 1 0 0 | cheat GFI Artifact_07 1 0 0 | cheat GFI ArtifactSE_01 1 0 0 | cheat GFI Artifact_01 1 0 0 | cheat GFI Artifact_08 1 0 0 | cheat GFI ArtifactAB_4 1 0 0 | cheat GFI Artifact_03 1 0 0 | cheat GFI Artifact_02 1 0 0 | cheat GFI ArtifactAB_2 1 0 0 | cheat GFI Artifact_06 1 0 0 | cheat GFI ArtifactAB_3 1 0 0 | cheat GFI Artifact_09 1 0 0 | cheat GFI Extinction_IceKaiju 1 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI ApexDrop_Allo 10 0 0 | cheat GFI ApexDrop_Basilo 10 0 0 | cheat GFI ApexDrop_Basilisk 10 0 0 | cheat GFI ApexDrop_Giga 10 0 0 | cheat GFI ApexDrop_Tuso 10 0 0 | cheat GFI ApexDrop_Rex 10 0 0 | cheat GFI ApexDrop_Yuty 10 0 0 | cheat GFI ApexDrop_Argentavis 10 0 0 | cheat GFI ApexDrop_Sarco 10 0 0 | cheat GFI ApexDrop_PoisonWyvern 10 0 0 | admincheat GFI ApexDrop_FireWyvern 10 1 0 | admincheat GFI ApexDrop_LightningWyvern 10 1 0 | admincheat GFI ApexDrop_Megalodon 10 1 0 | admincheat GFI ApexDrop_Sauro 10 1 0 | cheat GFI ApexDrop_Boa 10 0 0 | admincheat GFI ApexDrop_Megalania 10 0 0 | admincheat GFI ApexDrop_Spino 10 0 0 | admincheat GFI ApexDrop_Theriz 10 0 0 | admincheat GFI ApexDrop_Thylaco 10 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI PrimalItemConsumable_HealSoup 100 1 0 | cheat GFI PrimalItemConsumable_HealSoup 100 1 0 | cheat GFI PrimalItemConsumable_HealSoup 100 1 0 | cheat GFI PrimalItemConsumable_HealSoup 100 1 0 | cheat GFI PrimalItemConsumable_HealSoup 100 1 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_8(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0 | cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0| cheat GFI Berry_Mejoberry 100 0 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_9(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 | cheat GFI CookedMeat 100 0 0 ");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_10(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI Berry_Narcoberry 100 1 0 | cheat GFI Berry_Stimberry 100 1 0 | cheat GFI Berry_Tintoberry 100 1 0 | cheat GFI Berry_Azulberry 100 1 0 | cheat GFI Berry_Amarberry 100 1 0 | cheat GFI Berry_Verdberry 100 1 0 | cheat GFI Berry_Cianberry 100 1 0 | cheat GFI Berry_Magenberry 100 1 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Click_11(object sender, RoutedEventArgs e)
        {
            DataPackage dataPackage = new DataPackage();
            dataPackage.RequestedOperation = DataPackageOperation.Copy;
            dataPackage.SetText("cheat GFI SweetVeggieCake 100 1 0 | cheat GFI SweetVeggieCake 100 1 0 | cheat GFI SweetVeggieCake 100 1 0 | cheat GFI SweetVeggieCake 100 1 0 | cheat GFI SweetVeggieCake 100 1 0");
            Clipboard.SetContent(dataPackage);
        }

        private void Button_Change_Armour(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text == "Please Change Armour to Copy")
            {
                textBox1.Text = "Flak";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat GFI MetalHelmet 5 100 0 | cheat GFI MetalShirt 5 100 0 | cheat GFI MetalPants 5 100 0 | cheat GFI MetalGloves 5 100 0 | cheat GFI MetalBoots 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
            else if (textBox1.Text == "Flak")
            {
                textBox1.Text = "Tek";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat GFI PrimalItemArmor_TekBoots 5 100 0 | cheat GFI PrimalItemArmor_TekShirt 5 100 0 | cheat GFI PrimalItemArmor_TekGloves 5 100 0 | cheat GFI PrimalItemArmor_TekHelmet 5 100 0 | cheat GFI PrimalItemArmor_TekPants 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
            else if (textBox1.Text == "Tek")
            {
                textBox1.Text = "Fur";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat gfi FurPants 5 100 0 | cheat gfi FurShirt 5 100 0 | cheat gfi FurHelmet 5 100 0 | cheat gfi FurBoots 5 100 0 | cheat gfi FurGloves 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
            else if (textBox1.Text == "Fur")
            {
                textBox1.Text = "Ghillie";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat GFI GhillieBoots 5 100 0 | cheat GFI GhillieShirt 5 100 0 | cheat GFI GhillieGloves 5 100 0 | cheat GFI GhilliePants 5 100 0 | cheat GFI GhillieHelmet 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
            else if (textBox1.Text == "Ghillie")
            {
                textBox1.Text = "Riot";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat GFI RiotPants 5 100 0 | cheat GFI RiotShirt 5 100 0 | cheat GFI RiotGloves 5 100 0 | cheat GFI RiotBoots 5 100 0 | cheat GFI RiotHelmet 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
            else if (textBox1.Text == "Riot")
            {
                textBox1.Text = "Flak";
                DataPackage dataPackage = new DataPackage();
                dataPackage.RequestedOperation = DataPackageOperation.Copy;
                dataPackage.SetText("cheat GFI MetalHelmet 5 100 0 | cheat GFI MetalShirt 5 100 0 | cheat GFI MetalPants 5 100 0 | cheat GFI MetalGloves 5 100 0 | cheat GFI MetalBoots 5 100 0");
                Clipboard.SetContent(dataPackage);
            }
        }
    }
}
