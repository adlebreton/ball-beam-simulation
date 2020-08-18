// Fill out your copyright notice in the Description page of Project Settings.


#include "movementManager.h"

// Sets default values for this component's properties
UmovementManager::UmovementManager(){
	PrimaryComponentTick.bCanEverTick = true;
}

UmovementManager::~UmovementManager() {
	MManager.~UmemoryManager();
}

// Called when the game starts
void UmovementManager::BeginPlay(){
	Super::BeginPlay();

	//memory manager
	if (MManager.OpenMappedMemory())
		MManager.GetMappedMemoryData();

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
void UmovementManager::TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction){
	Super::TickComponent(DeltaTime, TickType, ThisTickFunction);
	/*_angle = _angle + way;
	if (_angle >= 45 || _angle <= -45)
		way = -way;
	set_target_angle(_angle);*/
	/*if (way >= 60) {
		_angle = -_angle;
		set_target_angle(_angle);
		way = 0;
	}else way++;*/

	/*FOutputDeviceNull ar;
	const FString command = FString::Printf(TEXT("set_angle %f"), _angle);
	parent->CallFunctionByNameWithArguments(*command, ar, NULL, true);*/
	
	float instruction;
	MManager.setDelta(DeltaTime);
	MManager.setCurrAngle(get_curr_angle());
	MManager.setCurrPos(get_ball_pos());
	
	instruction = MManager.getTargetAngle();
	//UE_LOG(LogTemp, Warning, TEXT("instruction: %f"), instruction);
	set_target_angle(instruction);
}

void UmovementManager::set_target_angle(float angle){
	/*FOutputDeviceNull ar;
	const FString command = FString::Printf(TEXT("set_angle %f"), angle);
	parent->CallFunctionByNameWithArguments(*command, ar, NULL, true);*/
	FRotator myRotator = FRotator::ZeroRotator;
	myRotator.Roll = angle;
	//UE_LOG(LogTemp, Warning, TEXT("instruction: %f"), angle);
	motor->SetAngularOrientationTarget(myRotator);
	beam->WakeRigidBody();//fixes the beam not moving after targeting -45 to 45
}

float UmovementManager::get_curr_angle(){
	/*FOutputDeviceNull ar;
	parent->CallFunctionByNameWithArguments(TEXT("get_angle"), ar, NULL, true);
	UE_LOG(LogTemp, Warning, TEXT("angle: %f"), beam->GetComponentRotation().Roll);*/
	return beam->GetComponentRotation().Roll;
}
float UmovementManager::get_ball_pos(){
	/*FOutputDeviceNull ar;
	parent->CallFunctionByNameWithArguments(TEXT("get_pos"), ar, NULL, true);*/
	FVector temp=beam->GetComponentTransform().InverseTransformPosition(ball->GetComponentLocation());
	/*UE_LOG(LogTemp, Warning, TEXT("pos monde: %f"), ball->GetComponentLocation().Y);
	UE_LOG(LogTemp, Warning, TEXT("pos relative: %f"), temp.Y);*/
	return temp.Y;
}

