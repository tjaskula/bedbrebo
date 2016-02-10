Domain Driven Design - CQRS - Event Sourcing application
=====================================================

The purpose of the application is to provide some basics for learning [Domain Driven Design](https://en.wikipedia.org/wiki/Domain-driven_design) aka DDD, [CQRS](http://martinfowler.com/bliki/CQRS.html) and [Event Sourcing](http://martinfowler.com/eaaDev/EventSourcing.html) aka ES. The approach focuses on the strategic and technical side of DDD, conversations with business expert which lead to the model creation, Bounded Context (BC) definition along with Uniquitous Language (UL). All modelisation steps are described in the project [wiki](https://github.com/tjaskula/bedbrebo/wiki).

Once the strategic side is established, we connect it with the technical implementation. Each choice of technology used in the project is documented and explained. You can read about the details in the [wiki](https://github.com/tjaskula/bedbrebo/wiki).

## The Domain

The domain is the "Bed and Breakfast Booking". The company BedBreBo has a web portal bedbrebo.com that allows users to book a B&B room available in the BedBreBo catalog.   
User can select geographical region, reservation date and check availabilities of rooms. Once the choice is made he can book the room.  
bedbrebo.com allows business customers to subscribe and manage their B&B offers. Each business customer can add to the portal as many B&B offers as they want. They can
update the schedule, number of available rooms, and see what has been already booked.

For the full list of business rules please look into the project [wiki](https://github.com/tjaskula/bedbrebo/wiki).

## The list of features

TODO

## The implementation

Two kinds of implementations are available; C# and F#, it you want to contribute in another language, please free to send a PR.

## The installation

TODO