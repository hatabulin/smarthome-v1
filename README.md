# SmartHome_v1 - front-end software, used SmartHome_v2 device driver, RGB device driver for control devices and LED strip.

This is my first training project in Visual Studio C#.NET
This software useing device driver on stm32 for communicate with power, encoders, and other sensors... Project placed: https://gitlab.com/sergiklutsk/SmartHome_v2

Application features:
- SmartHome device settings, control page - project on stm32 series mcu https://github.com/hatabulin/SmartHome_device
- RGB-Tape device settings, control, features page - project on stm32f103c8 mcu https://github.com/hatabulin/RGB_Tape
- VLC player (Favorite playlist, main playlist. Playlists controlled with IR-Remote via IR sensor connected to SmartHome device (https://github.com/hatabulin/SmartHome_device).
- Audio tools page (under construction) - for calculate frequency and synchronize with RGB-Tape controller (https://github.com/hatabulin/RGB_Tape).
- Log page.
- Esp8266 module - smart room (Page under construction) - project on esp8266 MCU connected to stm32 SmartHome devicevia UART. (WiFi GET/POST Web server for future controlling from Android devices)
- VideoCAM (under construction) - Video functions...motion e.t.c

