# Trezor.Net
Cross Platform C# Library for the [Trezor Cryptocurrency Hardwarewallet](https://trezor.io/)

**MacOS is coming! Some early experiments yielded results with a Trezor device using LibUsb on MacOS. When this is perfected it will be released with a MacOS sample.**

This library allows you to communicate with both Trezor hardwarewallets in the same way that the Trezor browser wallet app communicates with them. It can be used to build apps that send or receive crypto currencies like Bitcoin in a secure way.

cs````
        public async Task<string> GetAddressAsync()
        {
            //Register the factory for creating Usb devices. Trezor One Firmware 1.7.x, 1.8.x / Trezor Model T 2.1.x
            WindowsUsbDeviceFactory.Register();
            //Register the factory for creating Hid devices. Trezor One Firmware 1.6.x
            WindowsHidDeviceFactory.Register();

            var trezorManagerBroker = new TrezorManagerBroker(GetPin, 2000, new DefaultCoinUtility());

            var trezorManager =  await trezorManagerBroker.WaitForFirstTrezorAsync();

            var bip44AddressPath = AddressPathBase.Parse<BIP44AddressPath>("m/49'/0'/0'/0/0");

            return await trezorManager.GetAddressAsync(bip44AddressPath, false, true);
        }
````

Join us on Slack:
https://hardwarewallets.slack.com

Twitter:
https://twitter.com/HardfolioApp

Blog:
https://christianfindlay.wordpress.com

Currently supports:
* .NET Framework
* .NET Core
* Android
* UWP 
* Linux (Please use LibUsbDotNot as per the Unit Tests)

* Trezor One
* Trezor Model T

## Quick Start

- Clone the repo and open the solution
- There is a console sample, Xamarin Forms sample and unit tests for UWP, and .NET
- Compile one of the unit test apps, run the UWP/Android Xamarin Forms apps or,
- Go to Test->Windows->Text Explorer in Visual Studio
- Run one of the unit tests in the pane.
- Note that the UWP unit test has a UI for entering the pin. Please read instructions there. 

These samples mostly show you how to get addresses and sign transactions, but samples for other messages are being added.

Note: not all messages have a public method, but all messages exist. If you want to send a message to the Trezor you need to construct the message object and send it to the Trezor with the SendMessageAsync method. This requires that you know the result type before calling.

### Model T
There are now Model T Windows Unit Tests. These tests use LibUsb as the transport. Trezor One Firmware 1.7.x is also supported. The tests are in WindowsModelTAndOneTests. The same should also work on Android, but a working version in UWP is not yet available. There is no NuGet upgrade necessary for Model T or Firmware 1.7.x.

## NuGet

Install-Package Trezor.Net

## [Hid.Net, Usb.Net (Device.Net)](https://github.com/MelbourneDeveloper/Device.Net)

Trezor.Net communicates with the devices via the Hid.Net and Usb.Net libraries. You can see the repo for this library here.

## [Hardwarewallets.Net](https://github.com/MelbourneDeveloper/Hardwarewallets.Net)

This library is part of the Hardwarewallets.Net suite of libraries. It is an ambitious project aimed toward putting a set of common C# interfaces across all hardwarewallets

## [Contribution](https://github.com/MelbourneDeveloper/Trezor.Net/blob/master/CONTRIBUTING.md)

## Donate

All Hardwarewallets.Net libraries are open source and free. Your donations will contribute to making sure that these libraries keep up with the latest hardwarewallet firmware, functions are implemented, and the quality is maintained.

Bitcoin: 33LrG1p81kdzNUHoCnsYGj6EHRprTKWu3U

Ethereum: 0x7ba0ea9975ac0efb5319886a287dcf5eecd3038e

Litecoin: MVAbLaNPq7meGXvZMU4TwypUsDEuU6stpY

## Store App Production Usage

This app currently only Supports Trezor (https://github.com/MelbourneDeveloper/Trezor.Net) but it will soon support Ledger with this library.

https://play.google.com/store/apps/details?id=com.Hardfolio (Android)

https://www.microsoft.com/en-au/p/hardfolio/9p8xx70n5d2j (UWP)

## See Also

[Hardwarewallets.Net](https://github.com/MelbourneDeveloper/Hardwarewallets.Net) - Base level Hardwarewallet Library

[Ledger.Net](https://github.com/MelbourneDeveloper/Ledger.Net) - Ledger Hardwarewallet Library

[KeepKey.Net](https://github.com/MelbourneDeveloper/KeepKey.Net) - KeepKey Hardwarewallet Library

[LibUsbDotNet](https://github.com/LibUsbDotNet/LibUsbDotNet) - The latest Windows Unit Tests use this library. It can also be used to add Linux support.

These are the Trezor firmware open sources repos:

### Trezor One
https://github.com/trezor/trezor-mcu

### Trezor Model T
https://github.com/trezor/trezor-core

### Trezor Android Library - A client which is similar in design to Trezor.Net
https://github.com/trezor/trezor-android


