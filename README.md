## Travel booking service

Saga is a design pattern for managing long-running distributed transactions across multiple microservices, where each service owns its own database. Instead of relying on a single ACID transaction, a Saga coordinates a sequence of local transactions and uses compensating actions to undo completed steps if a later step fails. 
This approach improves scalability and service autonomy by eliminating the need for distributed transactions. It is particularly well suited for a travel booking system, where booking a flight, hotel, car rental, and processing payment are handled by independent services. If any reservation or payment fails, the Saga automatically triggers compensation (such as canceling previously reserved resources), ensuring the system remains in a consistent state.

The project demonstrates the Saga Orchestration pattern, where a central orchestrator manages the entire booking workflow. It coordinates service calls, tracks the progress of each step, and executes compensating actions to maintain consistency when failures occur.

<img width="508" height="385" alt="image" src="https://github.com/user-attachments/assets/cfe2389f-cb30-438f-9b8f-9ad4a96687c7" />
