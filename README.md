Domain Driven Design - CQRS - Event Sourcing application
=====================================================

1. Understanding the domain and business requirements

The domain is the "Bed and Breakfast Booking". The company BedBreBo has a web portal bedbrebo.com that allows users to book a B&B room available in the BedBreBo catalog. 
User can select geographical region, reservation date and check availabilities of rooms. Once the choice is made he can book the room.
bedbrebo.com allows business customers to subscribe and manage their B&B offers. Each business customer can add to the portal as many B&B offers as they want. They can
update the schedule, number of available rooms, and see what has been already booked.

Business requirements:

* A business customer can add B&Bs offers
* A B&B offer have a title, description, localization address, rooms, capacities and prices, schedule with availabilities of rooms
* A business customer can at any time connect to the portal to manage his offers:
	* change title and description
	* publish/unpublish offer so it's visible or not by users
	* see all upcoming bookings
	* cancel bookings
	* display information about person that has booked a room
	* change availabilities
* A user can browse for available B&B offers according to the geographical region and availability date
* A user can book a room and be redirected to the payment service
* Confirmation is sent to the user whether the payment has been accepted or rejected
* User can access his private space to see all the booking he has made
	* cancel it
	* change dates
	* change number of booked rooms
	
2. Defining the Ubiquitous language

Speak to the business expert and listen how he talks about the domain. What verbs and nouns are used? Ask questions about the domain.
What kind of behaviour do you see ? What are the business rules ? What are the business goals.

According to the requirements what are the main concept a user may identify :

* User


What questions may arise ?