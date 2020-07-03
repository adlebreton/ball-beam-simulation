// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "CoreMinimal.h"

/**
 * 
 */
class MYPROJECT_API ball_beam_interface
{
private:
	float ball_Y;
	float beam_angle;
public:
	ball_beam_interface();
	~ball_beam_interface();
	float get_beam_angel();
	void set_beam_angel();
	float get_ball_pos();
};
