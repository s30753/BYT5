# Design patterns -> Adapter, Factory and Observer

---

### Adapter pattern
our Adapter converts 2-dimensional array of Employees' data in to a list of employees with data. It is necessary for the BillingSystem to data in a suitable format.

--- 

### Factory pattern
in our case, using the Factory pattern allowed creating database objects on the go, no matter whether it is SQL Server or Oracle (both supported in the project). The logic is simpler and database-independent.


---

### Observer pattern
in our system, Observer pattern notifies all observers who subscribed to a subject when the state of the subject changes (availability). Observer also provides the functionality of adding and removing a subscription

