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
	TArray<UActorComponent*> ArrayChild;
	
	parent = (AActor*)this->GetOwner();

	parent->GetComponents<UActorComponent>(ArrayChild);
	for(int i = 0; i < ArrayChild.Num(); i++) {
		UActorComponent* child = ArrayChild[i];
		std::string name = std::string(TCHAR_TO_UTF8(*child->GetName()));
		if (name == "beam-mesh") {
			beam = (UStaticMeshComponent*)child;
		}
		else if (name == "Sphere") {
			ball = (UStaticMeshComponent*)child;
		}
		else if (name == "PhysicsConstraint") {
			motor = (UPhysicsConstraintComponent*)child;
		}
	}
	
}

// Called every frame
void UtestScripting::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction)
{
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	
	_angle = _angle + way;
	if (_angle >= 45 || _angle <= -45)
		way = -way;
	/*
	FOutputDeviceNull ar;
	const FString command = FString::Printf(TEXT("set_angle %f"), _angle);
	parent->CallFunctionByNameWithArguments(*command, ar, NULL, true);*/
	FRotator myRotator = FRotator::ZeroRotator;
	myRotator.Roll = _angle;
	motor->SetAngularOrientationTarget(myRotator);
	this->get_ball_pos();
	this->get_cur_angle();
}

void UtestScripting::set_target_angle(float angle) {
	/*FOutputDeviceNull ar;
	const FString command = FString::Printf(TEXT("set_angle %f"), angle);
	parent->CallFunctionByNameWithArguments(*command, ar, NULL, true);*/
	FRotator myRotator = FRotator::ZeroRotator;
	myRotator.Roll = angle;
	motor->SetAngularOrientationTarget(myRotator);
}

float UtestScripting::get_cur_angle() {
	/*FOutputDeviceNull ar;
	parent->CallFunctionByNameWithArguments(TEXT("get_angle"), ar, NULL, true);
	UE_LOG(LogTemp, Warning, TEXT("angle: %f"), beam->GetComponentRotation().Roll);*/
	return beam->GetComponentRotation().Roll;
}
float UtestScripting::get_ball_pos() {
	/*FOutputDeviceNull ar;
	parent->CallFunctionByNameWithArguments(TEXT("get_pos"), ar, NULL, true);*/
	FVector temp=beam->GetComponentTransform().InverseTransformPosition(ball->GetComponentLocation());
	/*UE_LOG(LogTemp, Warning, TEXT("pos monde: %f"), ball->GetComponentLocation().Y);
	UE_LOG(LogTemp, Warning, TEXT("pos relative: %f"), temp.Y);*/
	return temp.Y;
}

