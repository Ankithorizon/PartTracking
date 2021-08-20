# PartTracking

Technology
----------
- MVC .Net Core - 3.1

- Generic Repository, Unit Of Work

- EF Transaction

- Sql Server, T-Sql, Stored Procedures with Transaction

- Razor View, Partial View

- JQuery, Html, CSS, Bootstrap



System Process
--------------

- { Engineering-dept -> Part create/edit/view}
	
- { Warehouse-dept -> order for Part (refcode)}
	- [ create order with (status Confirmed) and generates (refcode) for future receiving of Part]
	- [ Edit - Order (Confirmed)]
	- [ View - Order (Confirmed/Received_WIP/Received)
	- [ Search - Order (Confirmed/Received_WIP/Received)
		 
		 
- { Receiving-dept -> receive Part (refcode)}
	- [ View - Receiving Details - Warehouse Order Details - Part Details for,,, Received_WIP/Received - Orders]
	- [ Search - Order (Received_WIP/Received)]
	- [ update Order (status from Confirmed) to 
		(Received_WIP(if received by installment quantity)) /
		(Received(if received by fully quantity))]
	- [ update quantity @Warehouse-Part ]
	- [ keeps track by receiving-quantity and receiving-date 
		with reference to (refcode)  ]

- { Production-dept -> WorkOrder}
	- [ WorkOrder connects with more than 1 Parts]
	- [ WorkOrder can not pull Parts more than required quantity]
	- [ WorkOrder can pull Parts from Warehouse by fully quantity or by installment quantity]
	- [ WorkOrder@Pulling-Parts -> update quantity @Warehouse-Part]
	- [ WorkOrder@Pulling-Parts keep track by pulling-quantity and pulling-date ]
		 
- {Tracking-Part}
	- [ Track Warehouse-Orders versus Part]
		- [ Track Receiving-Orders versus Part]
	- [ Track WorkOrders versus Part]
		- [ Track Pulling of Parts versus Part]





# Database


![database](https://user-images.githubusercontent.com/26190114/130287524-2240e7f7-db62-4197-8e88-ebae3593618a.PNG)

