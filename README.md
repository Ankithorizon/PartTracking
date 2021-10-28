# Part-Tracking-Service

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


# Screens

## Home->

![Home](https://user-images.githubusercontent.com/26190114/130300441-c3d5bad1-852c-4cbb-aa3b-275b2f4fc82e.PNG)


## Warehouse-Home->

![WarehouseHome](https://user-images.githubusercontent.com/26190114/130300663-78b31ae4-9574-4249-a6bb-926254314242.PNG)


## Warehouse-Search->

![WarehouseSearch](https://user-images.githubusercontent.com/26190114/130300678-eb2a37ad-3b22-4523-b964-e93c8c9292e7.PNG)




## Warehouse-Order-Add->

![WarehouseOrderAdd](https://user-images.githubusercontent.com/26190114/130300699-b3252de2-9ff6-4ce8-bb1d-44adc171ded3.PNG)




## Warehouse-Order-Add-Confirmed->

![Warehouse-OrderStatus-Confirmed](https://user-images.githubusercontent.com/26190114/139322254-f45d858b-9c6c-4303-a797-d24133d0e9fb.PNG)



## Warehouse-Order-Edit->

![WarehouseOrderEdit](https://user-images.githubusercontent.com/26190114/130300736-3390162f-972f-4ff0-9ad6-2ce0cf2a65bb.PNG)




## Warehouse-Order-View->

![WarehouseOrderView](https://user-images.githubusercontent.com/26190114/130300754-56e0febe-76b6-49f5-9b39-8399fb1bf650.PNG)




## Receiving-Home->

![ReceivingHome](https://user-images.githubusercontent.com/26190114/130300785-92f06ff8-2eeb-4c59-a9b4-f4b2d024be72.PNG)




## Receiving-Search->

![ReceivingSearch](https://user-images.githubusercontent.com/26190114/130300812-b73d585b-132a-48de-b332-27dee6c6d7bb.PNG)




## Receiving-Part->

![ReceivingPart](https://user-images.githubusercontent.com/26190114/130300826-4500ec84-1a25-4e3a-a625-74fae52eb181.PNG)




## ReceivingPart-Receive-By-Installment (Partially_WIP)->

![Receive-Partially](https://user-images.githubusercontent.com/26190114/139322349-b4cf5748-db53-4411-960b-d549b3baac80.PNG)




## ReceivingPart-Receive-By-Fully (Fully_Received)->

![Receive-Fully](https://user-images.githubusercontent.com/26190114/139322423-8bd8363b-3679-41dd-9836-393b4f95c0c0.PNG)




## Receiving-Details->

![ReceivingDetails](https://user-images.githubusercontent.com/26190114/130300852-ca08be8f-fad5-4b04-8b85-62206de13554.PNG)




## Production-WorkOrder-Home->

![ProductionWorkOrderHome](https://user-images.githubusercontent.com/26190114/130300860-7b8f16cb-878f-4071-b18a-94394f132a00.PNG)




## Production-WorkOrder-Search->

![ProductionWorkOrderSearch](https://user-images.githubusercontent.com/26190114/130300877-910752ec-26bb-485d-8703-27622e1c92ba.PNG)




## Production-WorkOrder-Pull-Part (Status:Green)->
### [Status:Green = WorkOrder has now already pulled all required Quantity of Part -- So further pulling of Part for this WorkOrder is Not Allowed]

![ProductionWorkOrderPullPartGreen](https://user-images.githubusercontent.com/26190114/130300894-40b2eaf8-ea3f-469e-99c6-578593c54a6f.PNG)




## Production-WorkOrder-Pull-Part (Status:Green - Response)->

![ProductionWorkOrderPullPartGreen_Response](https://user-images.githubusercontent.com/26190114/130300904-2c08e49f-e2b3-4053-ac01-f24114cbbc02.PNG)




## Production-WorkOrder-Pull-Part (Status:Red)->
### [Status:Red = WorkOrder cannot pull Part from Warehouse because Warehouse has 0[ZERO] Quantity available for Part]

![ProductionWorkOrderPullPartRed](https://user-images.githubusercontent.com/26190114/130300917-bb3dff58-a8ca-4d81-a538-e83fb290aedc.PNG)




## Production-WorkOrder-Pull-Part (Status:Red - Response)->

![ProductionWorkOrderPullPartRed_Response](https://user-images.githubusercontent.com/26190114/130300932-f97aa540-6a3b-4a19-a068-30495da9b3c4.PNG)




## Production-WorkOrder-Pull-Part (Status:Blue)->
### [Status:Blue = WorkOrder can pull Part from Warehouse]

![ProductionWorkOrderPullPartBlue](https://user-images.githubusercontent.com/26190114/130300946-39d94e55-79a4-4d5e-8240-5da9fe0b7793.PNG)




## Production-WorkOrder-Pull-Part (Status:Blue - Response)->

![ProductionWorkOrderPullPartBlue_ResponseError2](https://user-images.githubusercontent.com/26190114/130300960-af2e64ad-8396-445a-b375-98077d2df7cb.PNG)




## Production-WorkOrder-Pull-Part (Status:Blue - Response)->

![ProductionWorkOrderPullPartBlue_ResponseError1](https://user-images.githubusercontent.com/26190114/130300973-7adec060-95d9-4e96-85d3-5071f8b5d44e.PNG)




## Production-WorkOrder-Pull-Part-By-Installment (Status:Blue - Partially_Pulling)->

![ProductionWorkOrderPullPartBlue_PartiallyPulling](https://user-images.githubusercontent.com/26190114/130300989-c83e6f37-c1c3-43b8-8c2c-f8a73cb88c96.PNG)




## Production-WorkOrder-Pull-Part-By-Installment (Status:Blue - Partially_Pulling Response)->

![ProductionWorkOrderPullPartBlue_PartiallyPulling_Response](https://user-images.githubusercontent.com/26190114/130301004-236f82a6-c21f-4a59-ad80-ba636824b70c.PNG)




## Engineering-Home->

![EngineeringHome](https://user-images.githubusercontent.com/26190114/130301013-1b544325-e745-4370-a645-1cabb97ba45c.PNG)




## Engineering-Search->

![EngineeringSearch](https://user-images.githubusercontent.com/26190114/130301029-76dced1c-0d6d-4aa8-ab10-856110d223ea.PNG)




## Engineering-Part-Edit->

![EngineeringPartEdit](https://user-images.githubusercontent.com/26190114/130301039-ca389c72-c271-42a2-8282-c9b0526781b2.PNG)




## Engineering-Part-View->

![EngineeringPartView](https://user-images.githubusercontent.com/26190114/130301048-3ddcea0d-e150-4e03-957e-73b8d0cf16e8.PNG)




## Engineering-Part-Add [Duplicate_PartCode]->

![Duplicate_PartCode](https://user-images.githubusercontent.com/26190114/139322029-e09a2262-f79f-46bb-8260-a69eb5e73735.PNG)



## Engineering-Part-Add [ModelValidation_Success]->

![EngineeringPartAdd_ModelValidation_Success](https://user-images.githubusercontent.com/26190114/130301073-d8f915ed-d78f-4186-a521-0f06c543a0a2.PNG)




## Tracking-Home->

![TrackingHome](https://user-images.githubusercontent.com/26190114/130301089-acbf2f0a-f042-4b98-8c41-6087bc902a09.PNG)




## Tracking-Warehouse-Order->

![TrackingWarehouseOrder](https://user-images.githubusercontent.com/26190114/130301105-3463a83e-6010-4b90-b8b0-02b3621f7dac.PNG)




## Tracking-Receiving->

![TrackingReceiving](https://user-images.githubusercontent.com/26190114/130301118-cea9c538-e617-42e6-adf8-810cd59a29b4.PNG)




## Tracking-WorkOrder->

![TrackingWorkOrder](https://user-images.githubusercontent.com/26190114/130301148-fcf66e75-b981-4678-a80e-1d2007a02f00.PNG)




## Tracking-Part-Pulling->

![TrackingPartPulling](https://user-images.githubusercontent.com/26190114/130301161-b3dbf9f1-1884-413a-8afc-a8cffe23e8bd.PNG)




