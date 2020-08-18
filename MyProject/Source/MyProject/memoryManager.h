// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"


class MYPROJECT_API UmemoryManager
{

public:	
	// Sets default values for this component's properties
	UmemoryManager();
	~UmemoryManager();

	bool OpenMappedMemory();
	float* GetMappedMemoryData();
	void CloseSharedMemory();

	//setters and getters for value
	void setDelta(float delta);
	void setCurrPos(float pos);
	void setCurrAngle(float angle);
	float getTargetAngle();

private:
	void* SharedMemoryHandle; // Mapped memory handle.
	float* SharedMemoryData; // Pointer to memory data.
	/*float* _delta;
	float* _currPos;
	float* _currAngle;
	float* _targAngle;*/
};