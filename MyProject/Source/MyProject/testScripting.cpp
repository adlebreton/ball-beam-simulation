// Fill out your copyright notice in the Description page of Project Settings.


#include "testScripting.h"

// Sets default values for this component's properties
UtestScripting::UtestScripting()
{
	// Set this component to be initialized when the game starts, and to be ticked every frame.  You can turn these features
	// off to improve performance if you don't need them.
	PrimaryComponentTick.bCanEverTick = true;
	
}


// Called when the game starts
void UtestScripting::BeginPlay()
{
	Super::BeginPlay();

	parent = (AActor*)this->GetOwner();
	
}

// Called every frame
void UtestScripting::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	
	angle = angle + way;
	if (angle >= 45 || angle <= -45)
		way = -way;

	FOutputDeviceNull ar;
	const FString command = FString::Printf(TEXT("set_angle %f"), angle);
	parent->CallFunctionByNameWithArguments(*command, ar, NULL, true);

}

