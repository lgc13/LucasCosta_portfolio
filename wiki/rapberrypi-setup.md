### Playing with the Raspberry pi

### Controlling raspberry pi over ssh instead of screen sharing

1. Enable SSH on the Raspberry Pi (if not already enabled)
On your Raspberry Pi, run:

`sudo raspi-config`
Navigate to Interfacing Options → SSH → Enable
Exit and reboot the Pi:

2. Find the Raspberry Pi’s IP Address

`hostname -I`

or from your MacBook:
`ping raspberrypi.local`

If you get a response, you can connect using raspberrypi.local instead of an IP address.


3. Connect 

```sh
ssh pi@raspberrypi.local # connect
# add password
```
