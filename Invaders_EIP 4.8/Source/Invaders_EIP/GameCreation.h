// Fill out your copyright notice in the Description page of Project Settings.

#pragma once

#include "GameFramework/Actor.h"
#include "GameCreation.generated.h"

UCLASS()
class INVADERS_EIP_API AGameCreation : public AActor
{
	GENERATED_BODY()
	
public:	
	// Sets default values for this actor's properties
	AGameCreation();

	// Called when the game starts or when spawned
	virtual void BeginPlay() override;
	
	
	
};
