# HealthWatch 360

Rhiannon Wallace, Sam Moushey, Megha Pawar, Bengeo George, Sahana Sathiyanarayanan

<hr>

## Introduction

HealthWatch 360 is a mobile application that helps individuals monitor and improve their overall health and wellness.  

By integrating health risk statistics and nutritional data, HealthWatch 360 enables users to:
* Track lifestle habits
* Assess potential health risks
* Receive personalized healthcare recommendations
  
The app is designed for those looking to take control of their health with data-driven insights, empowering users to make better lifestyle choices and prevent common health issues like heart disease, diabetes, and obesity. 

## Logo
<img src="healthcare.png" alt="HealthWatch Logo" width="100" height="100">

## Story Board

1. Home Screen: Displays an overview of the user's health data, including nutrition intake, activity levels, and key health metrics. 
2. Health Risk Analysis: A dashboard where users can view health risk assessments based on their data and local health statistics from CDC. 
3. Nutrition Tracker: Allows users to log their meals and receive recommendations based on USDA food data. 
4. Exercise & Activity Tracking: Users can log daily exercise and track their activity levels. 
5. Health Reports: Users can generate weekly or monthly reports on their health and progress toward goals. 

<img src="Home.png" alt="Home page"> <img src="Nutrition.png" alt="Food page"> <img src="Activities.png" alt="Exercise page"> <img src="Reports.png" alt="Reports page"> <img src="Settings.png" alt="Settings page">

## Requirements
### Requirement #1: Tracking Daily Nutrition
*As a user, I want to track my nutritional intake so I can monitor my health more efficiently.*

#### Dependencies:
* User authentification for personal meal tracking
* USDA FoodData Central API data available and accessible
* Ability to allow for easy search and logging of meals
  
#### Assumptions:
* USDA API provides up-to-date and accurate nutritional data
* USDA API provides a sufficient coverage of food items applicable to users

##### Examples:
1.1<br/>
**Given** the user is logged in, <br/>
**When** the user logs a meal or snack, <br/>
**Then** the app should automatically calculate the total calories and nutrient for the day using the USDA API as its source.

2.1 <br/>
**Given** the user is tracking their food intake, <br/>
**When** the daily sodium level exceeds the recommended amount, <br/>
**Then** the app will display a notification that the user should reduce their sodium intake to better manage their health.

### Requirement #2:
*As a user, I want to receive a personalized health risk assessment so I can better understand my health.*

#### Dependencies:
* Access to CDC Health Data for region-specific health risk information

#### Assumptions:
*

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**


### Requirement #3:
*As a user, I want to track my physical activity so that I can see how my exercise habits impact my health.*

#### Dependencies:
* Syncing with third-party devices, such as smart watches, to log activities automatically
* User input of exercises into activity logging system

#### Assumptions:
* User will either manually log exercises or will have a compatible device that will automatically log exercises

#### Examples:
1.1 <br/>
**Given**  <br/>
**When**  <br/>
**Then**


### Requirement #4: Personalized Health Goals
*As a user, I want to set personal health goals so that I can stay motivated and track my progress over time.*

#### Dependencies:
* Goal-setting feature within the app
* Progress tracking and visualization tools (e.g., charts, milestones)
* Notifications and reminders system

#### Assumptions:
* Users are interested in setting and achieving personal health goals
* The app can accurately track progress towards these goals
* Users will engage with reminders and notifications

#### Examples:
1.1 <br/>
**Given** the user wants to improve their cardiovascular health, <br/>
**When** the user sets a goal to run 5 kilometers without stopping within two months, <br/>
**Then** the app should provide a training plan, track the user's runs, and display progress updates.


2.1 <br/>
**Given** the user aims to reduce daily sugar intake, <br/>
**When** the user sets a nutritional goal to consume less than 25 grams of sugar per day, <br/>
**Then** the app should monitor the user's food logs and alert them when they are approaching their daily limit.


### Requirement #5: Personalized Health Recommendations
*As a user, I want to receive personalized recommendations for improving my health based on my tracked data.*

#### Dependencies:
* Analytics engine to interpret user data
* Access to reliable health guidelines and resources (e.g., WHO, CDC)
* Content management system for delivering recommendations

#### Assumptions:
* Users are open to receiving health recommendations
* The app can accurately analyze user data to provide relevant suggestions
* Recommendations are tailored to individual user profiles and preferences

#### Examples:
1.1 <br/>
**Given** the user has consistently low fiber intake, <br/>
**When** the app analyzes the user's nutritional data over a week, <br/>
**Then** it should recommend high-fiber foods and recipes to incorporate into their diet.


2.1 <br/>
**Given** the user shows a trend of poor sleep quality, <br/>
**When** the app detects less than 6 hours of sleep per night over a month (from synced sleep data), <br/>
**Then** it should provide tips on improving sleep hygiene and suggest setting a regular sleep schedule.


### Requirement #6: Medication Tracking and Reminders
*As a user, I want to track my medication intake and receive reminders so that I can adhere to my prescribed schedule.*

#### Dependencies:
* Medication database with dosing schedules
* Reminder and notification system
* User interface for logging medication intake

#### Assumptions:
* Users are willing to input their medication schedules
* The app can send timely notifications
* Users will interact with reminders (e.g., mark as taken, snooze)

#### Examples:
1.1 <br/>
**Given** he user is prescribed a medication to be taken twice daily, <br/>
**When** the user inputs the medication name and schedule into the app, <br/>
**Then** the app should send reminders at the specified times and allow the user to confirm intake.


2.1 <br/>
**Given** the user missed a medication dose, <br/>
**When** the user does not confirm intake within 30 minutes of the scheduled time, <br/>
**Then** the app should send a follow-up notification and adjust the medication log accordingly.


### Requirement #7: Integration with Healthcare Providers
*As a user, I want to share my health data with my healthcare provider so that they can monitor my progress and adjust my care plan as needed.*

#### Dependencies:
* Secure data sharing protocols (e.g., HIPAA-compliant)
* Consent management system
* Interface for healthcare providers to view user data

#### Assumptions:
* Users are willing to share data with their providers
* Healthcare providers are willing and able to access data through the app
* Data sharing complies with all legal and privacy regulations such as HIPAA
Examples:

#### Examples:
1.1 <br/>
**Given** the user has granted consent to share data, <br/>
**When** the user's blood glucose levels are consistently high, <br/>
**Then** the app should notify the healthcare provider, allowing them to intervene or adjust treatment.


2.1 <br/>
**Given** the user is participating in a remote monitoring program, <br/>
**When** the user logs their daily blood pressure readings, <br/>
**Then** the healthcare provider can access this data in real-time to monitor for any concerning trends.


## Data Sources

[CDC Health Data](https://data.cdc.gov/)  
[USDA FoodData Central]([https://fdc.nal.usda.gov/fdc-app.html#/food-search?type=Foundation&query=](https://fdc.nal.usda.gov/download-datasets.html))

## Development Team
- Rhiannon Wallace
- Sam Moushey
- Megha Pawar
- Bengeo George
- Sahana Sathiyanarayanan

## Meeting Schedule
* Semester: Fall 2024 - Flex II
* Meeting Time & Location: Mondays at 1:00pm via Microsoft Teams


