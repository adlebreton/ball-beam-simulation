// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"
#include "Components/SceneComponent.h"
#include "Misc/OutputDeviceNull.h"
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

private:
	float angle = 0, way = 0.1;
	AActor* parent;

};
