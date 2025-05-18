# Postal Codes in JSON, XML and CSV format

**Postal codes / zipcodes with geo data from geonames.org converted to JSON, XML and CSV.**

## Countries (number of postal codes)
Last updated: 2025-05-18

- AD (7) - Andorra
- AE (178171) - United Arab Emirates
- AI (1) - Anguilla
- AL (494) - Albania
- AR (20260) - Argentina
- AS (1) - American Samoa
- AT (18957) - Austria
- AU (18521) - Australia
- AX (37) - Åland Islands
- AZ (1186) - Azerbaijan
- BD (1349) - Bangladesh
- BE (2781) - Belgium
- BG (5304) - Bulgaria
- BM (112) - Bermuda
- BR (5525) - Brazil
- BY (3133) - Belarus
- CA (1657) - Canada
- CC (1) - Cocos (Keeling) Islands
- CH (4520) - Switzerland
- CL (346) - Chile
- CN (2352) - China
- CO (3681) - Colombia
- CR (473) - Costa Rica
- CX (1) - Christmas Island
- CY (1127) - Cyprus
- CZ (15507) - Czechia
- DE (23297) - Germany
- DK (1159) - Denmark
- DO (544) - Dominican Republic
- DZ (15951) - Algeria
- EC (1225) - Ecuador
- EE (5398) - Estonia
- ES (37867) - Spain
- FI (3576) - Finland
- FK (1) - Falkland Islands
- FM (4) - Micronesia
- FO (130) - Faroe Islands
- FR (51611) - France
- GB (27450) - United Kingdom
- GF (77) - French Guiana
- GG (14) - Guernsey
- GI (1) - Gibraltar
- GL (33) - Greenland
- GP (105) - Guadeloupe
- GS (1) - South Georgia & South Sandwich Islands
- GT (548) - Guatemala
- GU (21) - Guam
- HK (1) - Hong Kong SAR
- HM (1) - Heard & McDonald Islands
- HN (38) - Honduras
- HR (6774) - Croatia
- HT (236) - Haiti
- HU (3571) - Hungary
- ID (81058) - Indonesia
- IE (139) - Ireland
- IM (87) - Isle of Man
- IN (155570) - India
- IO (1) - British Indian Ocean Territory
- IS (195) - Iceland
- IT (18415) - Italy
- JE (5) - Jersey
- JP (146883) - Japan
- KE (890) - Kenya
- KR (35583) - Korea
- LI (13) - Liechtenstein
- LK (1837) - Sri Lanka
- LT (21870) - Lithuania
- LU (4519) - Luxembourg
- LV (6101) - Latvia
- MA (1325) - Morocco
- MC (29) - Monaco
- MD (1753) - Moldova
- MH (2) - Marshall Islands
- MK (220) - North Macedonia
- MO (1) - Macao SAR
- MP (3) - Northern Mariana Islands
- MQ (100) - Martinique
- MT (73) - Malta
- MW (491) - Malawi
- MX (144655) - Mexico
- MY (2818) - Malaysia
- NC (52) - New Caledonia
- NF (1) - Norfolk Island
- NL (4334) - Netherlands
- NO (5132) - Norway
- NR (1) - Nauru
- NU (1) - Niue
- NZ (1738) - New Zealand
- PA (729) - Panama
- PE (96943) - Peru
- PF (207) - French Polynesia
- PH (2317) - Philippines
- PK (2563) - Pakistan
- PL (72900) - Poland
- PM (2) - St. Pierre & Miquelon
- PN (1) - Pitcairn Islands
- PR (177) - Puerto Rico
- PT (206942) - Portugal
- PW (1) - Palau
- RE (152) - Réunion
- RO (37915) - Romania
- RS (1155) - Serbia
- RU (43538) - Russia
- SE (18846) - Sweden
- SG (121154) - Singapore
- SI (556) - Slovenia
- SJ (8) - Svalbard & Jan Mayen
- SK (5233) - Slovakia
- SM (26) - San Marino
- TC (1) - Turks & Caicos Islands
- TH (903) - Thailand
- TR (36307) - Türkiye
- UA (29571) - Ukraine
- US (41489) - United States
- UY (1964) - Uruguay
- VA (1) - Vatican City
- VI (16) - U.S. Virgin Islands
- WF (3) - Wallis & Futuna
- WS (1) - Samoa
- YT (21) - Mayotte
- ZA (3920) - South Africa
 
## Format

Ready to go files in JSON, XML and CSV format.

### JSON

```
  {
    "country_code":"DE",
    "zipcode":"55252",
    "place":"Mainz-Kastel",
    "state":"Hessen",
    "state_code":"HE",
    "province":"Regierungsbezirk Darmstadt",
    "province_code":"064",
    "community":"Wiesbaden, Landeshauptstadt",
     "community_code":"06414",
    "latitude":"50.0102",
    "longitude":"8.2844"
  }
```

### CSV

```
  country_code,zipcode,place,state,state_code,province,province_code,community,community_code,latitude,longitude
  DE,55246,Mainz-Kostheim,Hessen,HE,Regierungsbezirk Darmstadt,064,"Wiesbaden, Landeshauptstadt",06414,50.0051,8.3134

```

### XML

```
  <object>
    <country_code>DE</country-code>
    <zipcode>01945</zipcode>
    <place>Grünewald</place>
    <state>Brandenburg</state>
    <state_code>BB</state-code>
    <province></province>
    <province_code>00</province-code>
    <community>Landkreis Oberspreewald-Lausitz</community>
    <community_code>12066</community-code>
    <latitude>51.4</latitude>
    <longitude>14</longitude>
  </object>
```

### Missing data?
Please contact geonames or ask in geonames forum https://forum.geonames.org/ for missing data. This repository is just a conversion of the original data.

## License

- Original creator: Data comes from http://www.geonames.org/ (Download allCountries.zip from http://download.geonames.org/export/zip/)
- Modifications: Transformed dataset into JSON, XML and CSV (see convert.rb) by Zauberware
- Updated modifications: Ported to .NET and update to latest data by pocki  
  Ready to use the project with .NET 9.0 SDK installed by running `dotnet run` in the project directory. (Actual data will get downloaded from geonames.org automatically)

- Type: This work is licensed under a Creative Commons Attribution 4.0 License. https://creativecommons.org/licenses/by/4.0/

## Do you need a developer who can work with these records?

Contact us here [www.zauberware.com](https://www.zauberware.com)
