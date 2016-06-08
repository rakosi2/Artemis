﻿using System.Drawing;
using System.Threading;
using System.Windows;
using Artemis.Properties;
using Artemis.Utilities;
using CUE.NET;
using CUE.NET.Brushes;
using CUE.NET.Devices.Generic.Enums;
using CUE.NET.Devices.Keyboard;
using Point = System.Drawing.Point;

namespace Artemis.DeviceProviders.Corsair
{
    public class CorsairRGB : KeyboardProvider
    {
        private CorsairKeyboard _keyboard;
        private ImageBrush _keyboardBrush;

        public CorsairRGB()
        {
            Name = "Corsair RGB Keyboards";
            CantEnableText = "Couldn't connect to your Corsair keyboard.\n" +
                             "Please check your cables and/or drivers (could be outdated) and that Corsair Utility Engine is running.\n" +
                             "In CUE, make sure \"Enable SDK\" is checked under Settings > Program.\n\n" +
                             "If needed, you can select a different keyboard in Artemis under settings.";
        }

        public override bool CanEnable()
        {
            // This will skip the check-loop if the SDK is initialized
            if (CueSDK.IsInitialized)
                return CueSDK.IsSDKAvailable(CorsairDeviceType.Keyboard);

            for (var tries = 0; tries < 9; tries++)
            {
                if (CueSDK.IsSDKAvailable(CorsairDeviceType.Keyboard))
                    return true;
                Thread.Sleep(2000);
            }
            return false;
        }

        /// <summary>
        ///     Enables the SDK and sets updatemode to manual as well as the color of the background to black.
        /// </summary>
        public override void Enable()
        {
            if (!CueSDK.IsInitialized)
                CueSDK.Initialize();

            _keyboard = CueSDK.KeyboardSDK;
            switch (_keyboard.DeviceInfo.Model)
            {
                case "K95 RGB":
                    Height = 7;
                    Width = 25;
                    PreviewSettings = new PreviewSettings(676, 190, new Thickness(0, -15, 0, 0), Resources.k95);
                    break;
                case "K70 RGB":
                    Height = 7;
                    Width = 21;
                    PreviewSettings = new PreviewSettings(676, 210, new Thickness(0, -25, 0, 0), Resources.k70);
                    break;
                case "K65 RGB":
                    Height = 7;
                    Width = 18;
                    PreviewSettings = new PreviewSettings(610, 240, new Thickness(0, -30, 0, 0), Resources.k65);
                    break;
                case "STRAFE RGB":
                    Height = 7;
                    Width = 22;
                    PreviewSettings = new PreviewSettings(665, 215, new Thickness(0, -5, 0, 0), Resources.strafe);
                    break;
            }
            Slug = "corsair-" + _keyboard.DeviceInfo.Model.Replace(' ', '-').ToLower();
            _keyboard.Brush = _keyboardBrush ?? (_keyboardBrush = new ImageBrush());
        }

        public override void Disable()
        {
            if (CueSDK.IsInitialized)
                CueSDK.Reinitialize();
        }

        /// <summary>
        ///     Properly resizes any size bitmap to the keyboard by creating a rectangle whose size is dependent on the bitmap
        ///     size.
        /// </summary>
        /// <param name="bitmap"></param>
        public override void DrawBitmap(Bitmap bitmap)
        {
            var image = ImageUtilities.ResizeImage(bitmap, Width, Height);

            // For STRAFE, stretch the image on row 2.
            if (_keyboard.DeviceInfo.Model == "STRAFE RGB")
            {
                var strafeBitmap = new Bitmap(22, 8);
                using (var g = Graphics.FromImage(strafeBitmap))
                {
                    g.DrawImage(image, new Point(0, 0));
                    g.DrawImage(image, new Rectangle(0, 3, 22, 7), new Rectangle(0, 2, 22, 7), GraphicsUnit.Pixel);
                }

                image = strafeBitmap;
            }

            _keyboardBrush.Image = image;
            _keyboard.Update();
        }
    }
}