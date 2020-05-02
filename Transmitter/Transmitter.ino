#include <Wire.h>
#include <HMC5883L.h>
#include <TinyGPS++.h>
#include <SoftwareSerial.h>
#include<LiquidCrystal_SR_LCD3.h>

const int pstr = 2;
const int pdata = 4;
const int pclk = 3;

LiquidCrystal_SR_LCD3
lcd(pdata, pclk, pstr);

HMC5883L compass; //deklarasi variable

static const int RXPin = 11, TXPin = 10; //deklarasi variable
static const uint32_t GPSBaud = 9600; //deklarasi untuk serial monitor

// The TinyGPS++ object
TinyGPSPlus gps; //deklarasi variable

// The serial connection to the GPS device
SoftwareSerial gpsSerial(10,11);

int error=0, s=0;
float kor;
String arah;
String titik_lat , titik_long, sendLat, sendLong;
float lattitude,longitude;
String kirimdata, user = "1";
float headingDegrees;
int  i, x = 0,y = 0;
String dp[10], bufferdata = "";
char bacadata;
boolean parsing = false;

void setup()
{
  Serial.begin(9600);
  lcd.begin(16,2);
  Wire.begin();
  gpsSerial.begin(9600);

//  pinMode(buzz,OUTPUT);
  
  compass = HMC5883L();
  Serial.println("Setting scale to +/- 1.3 Ga");
  error = compass.SetScale(1.3); // Set the scale of the compass.
  if(error != 0) // If there is an error, print it out.
  Serial.println(compass.GetErrorText(error));
  
  Serial.println("Setting measurement mode to continous.");
  error = compass.SetMeasurementMode(Measurement_Continuous); // Set the measurement mode to Continuous
  if(error != 0) // If there is an error, print it out.
  Serial.println(compass.GetErrorText(error));
//  lcd.print("tes");
}

void loop(){

  lcd.setCursor(0,0);
  lcd.print("track : on ");
  pilihkompas(); //manggil prosedur pilih kompas
  modulgps(); //manggil prosedur GPS
  kirimdata = '*' + user + ',' + titik_lat + ',' + titik_long + ',' + headingDegrees + ',' + '#' + '\n'; //membuat kirimdataa semua ini
  Serial.print(kirimdata); //Untuk mengirim data 
  delay(250); //jeda waktu untuk ke void loop lagi
}

void pilihkompas(){
 MagnetometerRaw raw = compass.ReadRawAxis();

  MagnetometerScaled scaled = compass.ReadScaledAxis ();
  int MilliGauss_OnThe_XAxis = scaled.XAxis;

  float heading = atan2(scaled.YAxis,scaled.XAxis);

  float declinationAngle = 0.0457;
  heading += declinationAngle;

  if(heading < 0)
  heading += 2*PI;

  if(heading > 2*PI)
  heading -= 2*PI;

  headingDegrees = heading * 180/M_PI;

  void Output(MagnetometerRaw raw, MagnetometerScaled scaled, float heading, float headingDegrees); // prosedur
  {
    lcd.setCursor(0,1);
    if ((headingDegrees >=355 && headingDegrees <= 360) || headingDegrees <= 5) {
      lcd.print("UTARA  ");
      
    }
    else if (headingDegrees >= 35 && headingDegrees <= 55) {
      lcd.print("TIMUR LAUT ");
      
    }
    else if (headingDegrees >= 85 && headingDegrees <= 95) {
      lcd.print("TIMUR ");
     
    }
    else if (headingDegrees >= 125 && headingDegrees <= 145) {
      lcd.print("TENGGARA ");
     
    }
    else if (headingDegrees >= 185 && headingDegrees <= 175) {
      lcd.print("SELATAN ");
     
      
    }
    else if (headingDegrees >= 215 && headingDegrees <= 235) {
      lcd.print("BARAT DAYA ");

    }
    else if (headingDegrees >= 265 && headingDegrees <= 275) {
      lcd.print("BARAT ");

    }
    else if (headingDegrees >= 305 && headingDegrees <= 325) {
      lcd.print("BARAT LAUT ");
     
    }
    else {
      lcd.print("..........");
    }
  //  lcd.print(headingDegrees);
}
}

void modulgps() {
  for (unsigned long start = millis();millis() - start < 1000;){
    while (gpsSerial.available() > 0){
    int data = gpsSerial.read(); //pembacaan serial GPS
    gps.encode(data);
    if (gps.location.isUpdated()){
//        lattitude = (gps.location.lat());  //float
 //       longitude = (gps.location.lng());
        titik_lat = String(gps.location.lat(), 7);
        titik_long = String(gps.location.lng(), 7);
  //      sendLat = titik_lat;
        sendLong = titik_long;
      }
      } 
    }
   }


