// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Components/SceneComponent.h"
#include "Misc/OutputDeviceNull.h"
#include "PhysicsEngine/PhysicsConstraintComponent.h"
#include "testScripting.generated.h"


UCLASS( ClassGroup=(Custom), meta=(BlueprintSpawnableComponent) )
class MYPROJECT_API UtestScripting : public USceneComponent
{
	GENERATED_BODY()

public:	
	// Sets default values for this component's properties
	UtestScripting();

protected:
	// Called when the game starts
	virtual void BeginPlay() override;

public:	
	// Called every frame
	virtual void TickComponent(float DeltaTime, ELevelTick TickType, FActorComponentTickFunction* ThisTickFunction) override;
	void set_target_angle(float angle);
	float get_cur_angle();
	float get_ball_pos();

private:
	float _angle = 0, way = 0.1;
	AActor* parent;
	UStaticMeshComponent* beam=NULL;
	UStaticMeshComponent* ball=NULL;
	UPhysicsConstraintComponent* motor=NULL;

};
