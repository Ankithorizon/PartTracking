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


# Screens

Home->
![Home](https://user-images.githubusercontent.com/26190114/130300441-c3d5bad1-852c-4cbb-aa3b-275b2f4fc82e.PNG)


WarehouseHome->
![WarehouseHome](https://user-images.githubusercontent.com/26190114/130300663-78b31ae4-9574-4249-a6bb-926254314242.PNG)


WarehouseSearch->
![WarehouseSearch](https://user-images.githubusercontent.com/26190114/130300678-eb2a37ad-3b22-4523-b964-e93c8c9292e7.PNG)


WarehouseOrderAdd->
![WarehouseOrderAdd](https://user-images.githubusercontent.com/26190114/130300699-b3252de2-9ff6-4ce8-bb1d-44adc171ded3.PNG)


WarehouseOrderAddConfirmed->
![WarehouseOrderAddConfirmed](https://user-images.githubusercontent.com/26190114/130300713-b710cd9b-6ff0-4d23-a14e-b78e8efb4433.PNG)


WarehouseOrderEdit->
![WarehouseOrderEdit](https://user-images.githubusercontent.com/26190114/130300736-3390162f-972f-4ff0-9ad6-2ce0cf2a65bb.PNG)


WarehouseOrderView->
![WarehouseOrderView](https://user-images.githubusercontent.com/26190114/130300754-56e0febe-76b6-49f5-9b39-8399fb1bf650.PNG)


ReceivingHome->
![ReceivingHome](https://user-images.githubusercontent.com/26190114/130300785-92f06ff8-2eeb-4c59-a9b4-f4b2d024be72.PNG)


ReceivingSearch->
![ReceivingSearch](https://user-images.githubusercontent.com/26190114/130300812-b73d585b-132a-48de-b332-27dee6c6d7bb.PNG)


ReceivingPart->
![ReceivingPart](https://user-images.githubusercontent.com/26190114/130300826-4500ec84-1a25-4e3a-a625-74fae52eb181.PNG)


ReceivingPart_Partially_WIP->
![ReceivingPart_Partially_WIP](https://user-images.githubusercontent.com/26190114/130300838-86dd3c33-bd90-4d17-b06e-c2c48eff4e8f.PNG)


ReceivingPart_Fully_Received->
![ReceivingPart_Fully_Received](https://user-images.githubusercontent.com/26190114/130300845-5e4af93b-8625-4955-906b-cbb03031df2c.PNG)


ReceivingDetails->
![ReceivingDetails](https://user-images.githubusercontent.com/26190114/130300852-ca08be8f-fad5-4b04-8b85-62206de13554.PNG)


ProductionWorkOrderHome->
![ProductionWorkOrderHome](https://user-images.githubusercontent.com/26190114/130300860-7b8f16cb-878f-4071-b18a-94394f132a00.PNG)


ProductionWorkOrderSearch->
![ProductionWorkOrderSearch](https://user-images.githubusercontent.com/26190114/130300877-910752ec-26bb-485d-8703-27622e1c92ba.PNG)


ProductionWorkOrderPullPartGreen->
![ProductionWorkOrderPullPartGreen](https://user-images.githubusercontent.com/26190114/130300894-40b2eaf8-ea3f-469e-99c6-578593c54a6f.PNG)


ProductionWorkOrderPullPartGreen_Response->
![ProductionWorkOrderPullPartGreen_Response](https://user-images.githubusercontent.com/26190114/130300904-2c08e49f-e2b3-4053-ac01-f24114cbbc02.PNG)


ProductionWorkOrderPullPartRed->
![ProductionWorkOrderPullPartRed](https://user-images.githubusercontent.com/26190114/130300917-bb3dff58-a8ca-4d81-a538-e83fb290aedc.PNG)


ProductionWorkOrderPullPartRed_Response->
![ProductionWorkOrderPullPartRed_Response](https://user-images.githubusercontent.com/26190114/130300932-f97aa540-6a3b-4a19-a068-30495da9b3c4.PNG)


ProductionWorkOrderPullPartBlue->
![ProductionWorkOrderPullPartBlue](https://user-images.githubusercontent.com/26190114/130300946-39d94e55-79a4-4d5e-8240-5da9fe0b7793.PNG)


ProductionWorkOrderPullPartBlue_ResponseError2->
![ProductionWorkOrderPullPartBlue_ResponseError2](https://user-images.githubusercontent.com/26190114/130300960-af2e64ad-8396-445a-b375-98077d2df7cb.PNG)


ProductionWorkOrderPullPartBlue_ResponseError1->
![ProductionWorkOrderPullPartBlue_ResponseError1](https://user-images.githubusercontent.com/26190114/130300973-7adec060-95d9-4e96-85d3-5071f8b5d44e.PNG)


ProductionWorkOrderPullPartBlue_PartiallyPulling->
![ProductionWorkOrderPullPartBlue_PartiallyPulling](https://user-images.githubusercontent.com/26190114/130300989-c83e6f37-c1c3-43b8-8c2c-f8a73cb88c96.PNG)


ProductionWorkOrderPullPartBlue_PartiallyPulling_Response->
![ProductionWorkOrderPullPartBlue_PartiallyPulling_Response](https://user-images.githubusercontent.com/26190114/130301004-236f82a6-c21f-4a59-ad80-ba636824b70c.PNG)


EngineeringHome->
![EngineeringHome](https://user-images.githubusercontent.com/26190114/130301013-1b544325-e745-4370-a645-1cabb97ba45c.PNG)


EngineeringSearch->
![EngineeringSearch](https://user-images.githubusercontent.com/26190114/130301029-76dced1c-0d6d-4aa8-ab10-856110d223ea.PNG)


EngineeringPartEdit->
![EngineeringPartEdit](https://user-images.githubusercontent.com/26190114/130301039-ca389c72-c271-42a2-8282-c9b0526781b2.PNG)


EngineeringPartView->
![EngineeringPartView](https://user-images.githubusercontent.com/26190114/130301048-3ddcea0d-e150-4e03-957e-73b8d0cf16e8.PNG)


EngineeringPartAdd_Duplicate_PartCode->
![EngineeringPartAdd_Duplicate_PartCode](https://user-images.githubusercontent.com/26190114/130301062-298f9af5-b7e1-45bd-960f-9127f87b185a.PNG)


EngineeringPartAdd_ModelValidation_Success->
![EngineeringPartAdd_ModelValidation_Success](https://user-images.githubusercontent.com/26190114/130301073-d8f915ed-d78f-4186-a521-0f06c543a0a2.PNG)


TrackingHome->
![TrackingHome](https://user-images.githubusercontent.com/26190114/130301089-acbf2f0a-f042-4b98-8c41-6087bc902a09.PNG)


TrackingWarehouseOrder->
![TrackingWarehouseOrder](https://user-images.githubusercontent.com/26190114/130301105-3463a83e-6010-4b90-b8b0-02b3621f7dac.PNG)


TrackingReceiving->
![TrackingReceiving](https://user-images.githubusercontent.com/26190114/130301118-cea9c538-e617-42e6-adf8-810cd59a29b4.PNG)


TrackingWorkOrder->
![TrackingWorkOrder](https://user-images.githubusercontent.com/26190114/130301148-fcf66e75-b981-4678-a80e-1d2007a02f00.PNG)


TrackingPartPulling->
![TrackingPartPulling](https://user-images.githubusercontent.com/26190114/130301161-b3dbf9f1-1884-413a-8afc-a8cffe23e8bd.PNG)


